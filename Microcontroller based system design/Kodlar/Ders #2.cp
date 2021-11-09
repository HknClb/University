#line 1 "C:/Users/hkncl/Desktop/Bahar Yarýyýlý  4.Dönem Derser/Mikrokontrol Tabanlý Sistem Tasarýmý/Kodlar/Ders #2.c"
void main()
{
 unsigned short i = 0;
 const char display[10] = {0X3F, 0X06, 0X5B, 0X4F, 0X66, 0X6D, 0X7D, 0X07, 0X7F, 0X6F};
 trisb = 0;
 portb = 0X3F;
 for(i = 0; i < 11; i++)
 {
 if(i == 10)
 i = 0;
 portb = display[i];
 delay_ms(500);
 }
}
