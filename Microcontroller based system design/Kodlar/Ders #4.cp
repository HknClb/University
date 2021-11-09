#line 1 "C:/Users/hkncl/Desktop/Bahar Yarýyýlý  4.Dönem Derser/Mikrokontrol Tabanlý Sistem Tasarýmý/Kodlar/Ders #4.c"


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
#line 43 "C:/Users/hkncl/Desktop/Bahar Yarýyýlý  4.Dönem Derser/Mikrokontrol Tabanlý Sistem Tasarýmý/Kodlar/Ders #4.c"
unsigned short int isDisplay = 0;
unsigned char selection;

void main()
{
 trisb.rb0 = trisb.rb1 = 1;
 portb.rb0 = portb.rb1 = 1;
 Lcd_Init();
 do
 {
 if(!isDisplay)
 {
 Lcd_Cmd(_LCD_BLINK_CURSOR_ON);
 Lcd_Cmd(_LCD_CLEAR);
 Lcd_Out_Cp("Hakan");
 delay_ms(750);
 Lcd_Out(2, 6, " CELEBI");
 Lcd_Cmd(_LCD_CURSOR_OFF);
 isDisplay = 1;
 }
 if(!portb.rb0)
 {
 Lcd_Cmd(_LCD_CLEAR);
 Lcd_Out_Cp("Lcd Cleaned !");
 delay_ms(1000);
 Lcd_Cmd(_LCD_CLEAR);
 Lcd_Cmd(_LCD_TURN_OFF);
 while(!portb.rb0);
 }
 if(!portb.rb1)
 {
 Lcd_Cmd(_LCD_CLEAR);
 Lcd_Cmd(_LCD_TURN_ON);
 isDisplay = 0;
 while(!portb.rb1);
 }

 }while(1);

}
