void main()
{
   trisb = 0;
   portb = 0x0F;
   trisd.rd0 = 1;
   trisd.rd1 = 1;
   portd.rd0 = 0;
   portd.rd1 = 0;
   while(1)
   {
      if(portd.rd0)
      {
         portb = ~portb;
         while(portd.rd0);
      }
   }
}