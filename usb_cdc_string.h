/* #include <usb_cdc_string.h>
*
* Creada por: Ing. Abiezer Hernandez O.
* Fecha de creacion: 21/07/2020
* Electronica y Circuitos
*
*/

void usb_read_string(char* s, unsigned int max)
{
   unsigned int len;
   char c;
   --max;
   len=0;
   do {
     c = usb_cdc_getc();
     if(c==8) {
        if(len>0){
          len--;
        }
     }else if ((c>=' ')&&(c<='~'))
       if(len<max){
         s[len++]=c;
       }
   } while(c!=13);
   s[len]=0;
}

void usb_read_substring(char* cp, char* vc, int inc , int fn)
{
   int pt = 0;
   for(int lt=inc; lt<=fn; lt++)
   {
      vc[pt] = cp[lt];
      pt++;
   }
   pt = 0;
}

void usb_read_string_until(char stopchar, char* buffer_rx, int st_size)
{
   unsigned int con_t = 0;
   while(*(buffer_rx-1) != stopchar)
   {
      con_t++;
      *buffer_rx++ = usb_cdc_getc();
      if(con_t >= st_size) break;
   }
   *--buffer_rx=0;
}

void usb_read_substring_plot(char* cp, char* vc, int inc , int fn)
{
   int pt = 0;
   for(int lt=inc; lt<=fn; lt++)
   {
      vc[pt] = cp[lt];
      pt++;
   }
   vc[pt] = '\0';
   pt = 0;
}

void usb_read_plot(char b_ini, char b_fin, char* tr_or, char* n_str, int s_buf)
{
   int i = 0;
   int j = 0;
   int conta_ini = 0;
   int conta_fin = 0;
   
   for(i=0; i<s_buf; i++)
   {
      if(tr_or[i] == b_ini){
         conta_ini = i;
      }
   }
   for(j=0; j<s_buf; j++)
   {
      if(tr_or[j] == b_fin){
         conta_fin = j;
      }
   }
   usb_read_substring_plot(tr_or, n_str, conta_ini+1, conta_fin-1);
}