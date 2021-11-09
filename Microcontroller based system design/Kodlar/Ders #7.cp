#line 1 "C:/Users/hkncl/Desktop/Bahar Yarýyýlý  4.Dönem Derser/Mikrokontrol Tabanlý Sistem Tasarýmý/Kodlar/Ders #7.c"
#line 25 "C:/Users/hkncl/Desktop/Bahar Yarýyýlý  4.Dönem Derser/Mikrokontrol Tabanlý Sistem Tasarýmý/Kodlar/Ders #7.c"
short int counter;

void interrupt()
{
 if(tmr0if_bit == 1)
 {
 counter++;;
 tmr0 = 158;
 tmr0if_bit = 0;
 }
}

void main()
{
 trisb = portb = counter = 0;
 portb.rb0 = 0;
 option_reg = 0xC7;
 intcon = 0xC0;
 tmr0ie_bit = 1;
 tmr0if_bit = 0;
 tmr0 = 158;
 while(1)
 {

 if(counter >= 100)
 {
 counter = 0;
 portb.rb0 = ~portb.rb0;
 }
 }
}
