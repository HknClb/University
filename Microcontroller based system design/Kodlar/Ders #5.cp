#line 1 "C:/Users/hkncl/Desktop/Bahar Yarýyýlý  4.Dönem Derser/Mikrokontrol Tabanlý Sistem Tasarýmý/Kodlar/Ders #5.c"
void interrupt()
{
 if(intcon.intf == 1)
 {
 intcon.gie = 0;
 portb.rb1 = ~portb.rb1;
 intcon.intf = 0;
 intcon.inte = 1;
 }
}

void main()
{
 trisb = 0x01;
 portb.rb1 = 1;
 intcon.intf = 0;
 intcon.inte = 1;
 intcon.gie = 1;
 intcon.peie = 0;
 option_reg.intedg = 0;
 while(1);
}
