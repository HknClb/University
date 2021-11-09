void main()
{
   ADCON1 |= 0X0f;
   trisb = 0;
   portb = 0;
   while(0 == 0)
   {
      portb.b7 = 1;
      delay_ms(500);
      portb.b7 = 0;
      portb.b6 = 1;
      delay_ms(500);
      portb.b6 = 0;
      portb.b5 = 1;
      delay_ms(500);
      portb.b5 = 0;
      portb.b4 = 1;
      delay_ms(500);
      portb.b4 = 0;
      portb.b3 = 1;
      delay_ms(500);
      portb.b3 = 0;
      portb.b2 = 1;
      delay_ms(500);
      portb.b2 = 0;
      portb.b1 = 1;
      delay_ms(500);
      portb.b1 = 0;
      portb.b0 = 1;
      delay_ms(500);
      portb.b0 = 0;
   }
}