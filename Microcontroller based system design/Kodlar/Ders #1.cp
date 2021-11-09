#line 1 "C:/Users/hkncl/Desktop/Bahar Yarýyýlý  4.Dönem Derser/Mikrokontrol Tabanlý Sistem Tasarýmý/Kodlar/Ders #1.c"
void main()
{
 trisb = 0;
 portb = 0x0F;
 trisd.rd0 = 1;
 portd.rd0 = 0;
 while(1)
 {
 if(portd.rd0)
 {
 portb = ~portb;
 while(portd.rd0);
 }
 }
}
