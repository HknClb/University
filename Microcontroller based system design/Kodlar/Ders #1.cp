#line 1 "C:/Users/hkncl/Desktop/Bahar Yar�y�l�  4.D�nem Derser/Mikrokontrol Tabanl� Sistem Tasar�m�/Kodlar/Ders #1.c"
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
