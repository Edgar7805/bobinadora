# bobinadora
bobinadora semi automatica
bobinadora basada en microntrolador pic18f4550.
compilador usado CCS PIC C compiler.
controla 2 motores parado paso un para el eje x (avance del bobinado ), otro para el C(rotacion)
mediante drivers como el DRV8825, A4988.
los datos deben cargarse mediante la interfaz suministrada u otra plaicaicon para enviar datos seriales
tener en cuenta el formato de la trama de datos ya que la interfaz suministrada hace los calculos y envia
solo las intrucciones en el siguiente formato #Vueltas_PasoxVuelta _CambiarSentido_TipoPaso_estado_% 
cuenta con caracter de inicia(#) y final("%") de trama y separadores de trama ("_") 
la conexion el mediante  USB CDC(emulacion de puerto serial).

