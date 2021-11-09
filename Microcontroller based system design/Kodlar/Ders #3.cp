#line 1 "C:/Users/hkncl/Desktop/Bahar Yarýyýlý  4.Dönem Derser/Mikrokontrol Tabanlý Sistem Tasarýmý/Kodlar/Ders #3.c"



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
 if(display < 0)
 display = 9;
 else if(display > 9)
 display = 0;
 portb = display;
 }
}
