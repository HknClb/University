#line 1 "C:/Users/hkncl/Desktop/Bahar Yarýyýlý  4.Dönem Derser/Mikrokontrol Tabanlý Sistem Tasarýmý/Kodlar/Odev #5.c"
void interrupt(void)
{
 if(intcon.rbif)
 {
 intcon.gie = 0;

 portb = 0;
 if(portb.rb4)
 portb.rb0 = ~portb.rb0;
 else if(portb.rb5)
 portb.rb1 = ~portb.rb1;
 else if(portb.rb6)
 portb.rb2 = ~portb.rb2;
 else if(portb.rb7)
 portb.rb3 = ~portb.rb3;
 }
 while(portb.rb4);
 while(portb.rb5);
 while(portb.rb6);
 while(portb.rb7);
 portb = portb;
 intcon.rbif = 0;
 intcon.gie = 1;
}

void main(void)
{
 trisb = 0XF0;
 portb = 0;
 intcon.rbif = 0;
 intcon.rbie = 1;
 intcon.gie = 1;
 intcon.peie = 0;
 while(1);
}
