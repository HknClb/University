#define write portb.rb0
#define clear portb.rb1
#define shift_left portb.rb2
#define shift_right portb.rb3

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
        if(clear)
        {
            Lcd_Cmd(_LCD_CLEAR);
            while(clear);
        }
        if(write)
        {
            Lcd_Cmd(_LCD_CLEAR);
            Lcd_Out_Cp("Hakan");
            Lcd_Out(2, 6, "CELEBI");
            while(write);
        }
        if(shift_left)
        {
            Lcd_Cmd(_LCD_SHIFT_LEFT);
            while(shift_left);
        }
        if(shift_right)
        {
            Lcd_Cmd(_LCD_SHIFT_RIGHT);
            while(shift_right);
        }
    }
}