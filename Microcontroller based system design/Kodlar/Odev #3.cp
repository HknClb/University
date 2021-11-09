#line 1 "C:/Users/hkncl/Desktop/Bahar Yarýyýlý  4.Dönem Derser/Mikrokontrol Tabanlý Sistem Tasarýmý/Kodlar/Odev #3.c"



short display = 0;

void main()
{
 trisb = 0;
 portb = 0;
 trisc = 0x03;
 portc = 0;
 while(1)
 {
 if(! PORTC.RC0 )
 {
 display++;
 while(! PORTC.RC0 );
 }
 if(! PORTC.RC1 )
 {
 display--;
 while(! PORTC.RC1 );
 }
 if(display > 99)
 display = 0;
 else if(display < 0)
 display = 99;
 portb = dec2bcd(display);
 }
}
