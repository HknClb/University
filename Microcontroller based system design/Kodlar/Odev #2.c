void main()
{
   const display[10] = {0X3F, 0X06, 0X5B, 0X4F, 0X66, 0X6D, 0X7D, 0X07, 0X7F, 0X6F};
   unsigned short i = 0;
   trisb = 0;
   portb = display[i];
   trisd.rd0 = trisd.rd1 = 1;
   portd.rd0 = portd.rd1 = 0;
   while(1)
   {
      if(portd.rd0)
      {
         if(i != 9)
            portb = display[++i];
         else
         {
            i = 0;
            portb = display[i];
         }
         /*Butona týkladýktan sonra portd 1 oluyor tekrar 0 olmasý için bir süre geçtiði için programý bekletiyoruz.*/
         delay_ms(300);
      }
      if(portd.rd1)
      {
         if(i != 0)
            portb = display[--i];
         else
         {
            i = 9;
            portb = display[i];
         }
         delay_ms(300);
      }
   }
}