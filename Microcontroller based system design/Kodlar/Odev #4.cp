#line 1 "C:/Users/hkncl/Desktop/Bahar Yarýyýlý  4.Dönem Derser/Mikrokontrol Tabanlý Sistem Tasarýmý/Kodlar/Odev #4.c"





sbit LCD_RS at RD2_bit;
sbit LCD_EN at RD3_bit;
sbit LCD_D4 at RD4_bit;
sbit LCD_D5 at RD5_bit;
sbit LCD_D6 at RD6_bit;
sbit LCD_D7 at RD7_bit;
sbit LCD_RS_Direction at TRISD2_bit;
sbit LCD_EN_Direction at TRISD3_bit;
sbit LCD_D4_Direction at TRISD4_bit;
sbit LCD_D5_Direction at TRISD5_bit;
sbit LCD_D6_Direction at TRISD6_bit;
sbit LCD_D7_Direction at TRISD7_bit;

void main()
{
 trisb = 0x04;
 portb = 0;
 Lcd_Init();
 Lcd_Cmd(_LCD_CLEAR);
 Lcd_Out_Cp("PIC16F877A");
 Lcd_Out(2, 9, "MICRO-C");
 Lcd_Cmd(_LCD_CURSOR_OFF);
 while(1)
 {
 if( portb.rb1 )
 {
 Lcd_Cmd(_LCD_CLEAR);
 while( portb.rb1 );
 }
 if( portb.rb0 )
 {
 Lcd_Cmd(_LCD_CLEAR);
 Lcd_Out_Cp("Hakan");
 Lcd_Out(2, 6, "CELEBI");
 while( portb.rb0 );
 }
 if( portb.rb2 )
 {
 Lcd_Cmd(_LCD_SHIFT_LEFT);
 while( portb.rb2 );
 }
 if( portb.rb3 )
 {
 Lcd_Cmd(_LCD_SHIFT_RIGHT);
 while( portb.rb3 );
 }
 }
}
