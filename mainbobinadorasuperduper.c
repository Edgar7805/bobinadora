#include <18F4550.h>
#device PASS_STRINGS = IN_RAM
#fuses HSPLL , PLL5, USBDIV,  CPUDIV1, NOPROTECT, NODEBUG,  VREGEN, NOWDT
#use delay(crystal=48Mhz)



//prototipado de funciones
void procesar_tramas(void);
void calibrar(void);
void bobinar(void);



#define USB_CDC_DATA_LOCAL_SIZE  128
// Includes all USB code and interrupts, as well as the CDC API

#include <usb_cdc.h>
#include <stdlib.h>
#include <string.h>
#include <usb_cdc_string.h>

//variable globales

//datos de la trama
unsigned int16 vueltas = 0;  
unsigned int16 loop_Cambiar_sentido = 0;  //veces que llega
char trama_entrada[30]={"00000000000000000000000000000"};//trama recibida
int paso =1;
int iniciar = 0;
int pasos_en_x_vuelta=0;
unsigned int16 pasos_rotacion = 199;
int1 error_motor_X = FALSE;
int1 error_motor_R = FALSE;
#INT_COMP
void isr_comp(){
  if(C1OUT==False){               //si esta en estado bajo el registro no hay error
     vueltas=0;
     error_motor_X=true;
  }
  if(C2OUT==False){
     error_motor_r=true;
     vueltas=0;
  }
  
}


void procesar_tramas(){
    char separador[] = "_"; 
    char*puntero =(char*)trama_entrada; 
    if(puntero[0]=='#'){
        char *token;
        //buscar y convertir lo encontrado antes del 1er separador(vueltas)
        token = strtok(puntero +1,separador );
        vueltas = atol(token);
        //buscar y convertr lo que hay depues del 1er separador (pasos en x)
        token = strtok(NULL, separador);
        pasos_en_x_vuelta = atoi(token);
        
       //buscar y converir lo que hay en el 2do y 3r separador (loop) 
        token = strtok(NULL, separador);
        loop_cambiar_sentido = atol(token);       
        //buscar y convertir lo que hay en el 3r y 3to seprador
        token = strtok(NULL, separador);
        paso = atoi(token);
        
        token =strtok(NULL,separador);
        iniciar = atoi(token);
        
        
        //evita re entrar en la funcion en en loop
        
        printf(usb_cdc_putc," datos vueltas: %li  paso por vuelta %i loop:%li paso: %i estado: %d \r\n",vueltas,pasos_en_x_vuelta, loop_cambiar_sentido, paso, iniciar);
        //procesar_trama = 0;
    }
     
}

void configurar_puerto(){   //designa las salidas del puerto segun el paso de motor desado
                           //los primeros 3 bits definen el tipo de paso
                           //el bit
    switch (paso){
      case 1:  //paso completo
        output_d(0b00000000);
        break;
     case 2:  // 1/2 paso
        output_d(0b100000000);
        break;   
    case 4:   // un 1/4 de paso
       output_d(0b01001000);
        break;
    case 8:   // 1/8 de paso
       output_d(0b11000000);
        
        break;
    }





}

void calibrar(){
   if(input_state(PIN_B7)==0){
      usb_cdc_putc("\rcalibracion\n");
      delay_ms(100);
      output_high(PIN_D3);  
      while(input_state(PIN_B7)!=1){
          output_high(PIN_D4);
          delay_us(400);
          output_low(PIN_D4);
          delay_us(400);
      }
   }
   usb_cdc_putc("\rlisto para comenzar\n");
   delay_ms(100);


}


void bobinar (){
    
    int16 loop_referencia =0; 
    output_d(0b00000000);
    while(vueltas>0){
        output_high(PIN_D0);  //pulso motor B
        delay_us(600);
        output_low(PIN_D0);
        delay_us(600);
        pasos_rotacion--;
        
        //al completar una vuelta 
        if (pasos_rotacion==0){
            vueltas--;
            printf(usb_cdc_putc,"%li\r\n",vueltas);
            pasos_rotacion = 199;
            //hace havanzar el ejex
            int8 t = 0;
            while( t<=pasos_en_x_vuelta){
                output_high(PIN_D4); //pulso botor A
                delay_us(600);
                output_low(PIN_D4);
                delay_us(600);
                t++;
               
            }
            loop_referencia++;
            if(loop_referencia==loop_cambiar_sentido){
               output_toggle(PIN_D3);//cambia el sentido del eje X
               loop_referencia = 0;
            
            }
             
             
        }
    }
    if (error_motor_x== TRUE || error_motor_r== TRUE){
        while(true){
        usb_cdc_putc("\rsobre temperatura de motor re inicia r\n ");
        delay_ms(200);
        }
    }
    
    usb_cdc_putc("\r completado\n");
    delay_ms(10);
    iniciar=0;
   
}

      
void main(){   
   
   //GPIO's
   set_tris_c(0b00000000);
   set_tris_d(0b00000000);
   set_tris_b(0xff);
  
   output_c(0b00000000);
   output_d(0b00000000);
   output_a(0b00000000);
   
   //interrupcion RB0
 //  enable_interrupts(INT_RB);
  // enable_interrupts(GLOBAL);
  // EXT_INT_EDGE(H_TO_L);
  setup_comparator(A0_A3_A1_A3); // 2 comparadores con misma referencia
  enable_interrupts(global);
  enable_interrupts(INT_COMP);
  //cosas del usb
   usb_cdc_init();
   usb_cdc_line_coding.dwDTERrate = 57600;
   usb_init();
   
   //enable_interrupts(INT_RDA); //Habilita Interrupción por serial (Recepcion USB_CDC)
   //enable_interrupts(GLOBAL);  //Habilita todas las interrupciones
   while(TRUE){
      usb_task();  //Verifica la comunicación USB
      if(usb_enumerated()) {
         
         //esperar datos
          
         //trama de entrada
         // separador de trama "_"
         //formato  #vueltas_longitudbobina(mm)_calibre_estado_$
         // Almacena  datos leidos del USB CDC
              
               if(usb_cdc_kbhit()){
                   usb_read_string_until('%',trama_entrada,30);
                   procesar_tramas();  
               }
               if(iniciar==1){
                 configurar_puerto();
                 Calibrar();
                 bobinar();
               
               }                  
       }
       
         
    }    
}

 
