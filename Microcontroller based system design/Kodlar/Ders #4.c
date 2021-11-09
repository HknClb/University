/*Burada yapýlan iþlemler pinleri birbirlerine eþitlemektir. Yani lcd rs pinini rd2 portuna baðladýk gibi.*/

sbit LCD_RS at RD2_bit;
sbit LCD_EN at RD3_bit;
sbit LCD_D4 at RD4_bit;
sbit LCD_D5 at RD5_bit;
sbit LCD_D6 at RD6_bit;
sbit LCD_D7 at RD7_bit;

/*Lcd çýkýþ baðlantýlarýný porta verdik.*/
sbit LCD_RS_Direction at TRISD2_bit;
sbit LCD_EN_Direction at TRISD3_bit;
sbit LCD_D4_Direction at TRISD4_bit;
sbit LCD_D5_Direction at TRISD5_bit;
sbit LCD_D6_Direction at TRISD6_bit;
sbit LCD_D7_Direction at TRISD7_bit;

/*Bazý temel fonksiyonlar
    -Lcd_Init() -> Lcd display'i kullanýma hazýr hale getirir. Bunu yapmak zorundayýz.
    -Lcd_Out(1(Satýr), 3(Sütun), "Merhaba"(Herhangi bir katar)) -> Belirlenen satýr ve sütundan baþlayarak verilen katarý ekrana yazdýrýr.
    -Lcd_Out_Cp("Sivas EML") -> Ýmlecin bulunduðu konumdan baþlayarak belirtilen katarý ekrana yazdýrýr.
    -Lcd_Chr(2, 3, 'H') -> Belirtilen satýr ve sütundan baþlayarak verilen karakteri ekrana yazdýrýr.
    -Lcd_Chr_Cp('H') -> Ýmlecin bulunduðu konumdan baþlayarak karakteri ekrana yazdýrýr.
    -Lcd_Cmd(Komut) -> Parametre olarak girilen komutu iþler.
        _LCD_FIRST_ROW -> Ýmleci 1.Satýra taþýr.
        _LCD_SECOND_ROW -> Ýmleci 2.Satýra taþýr.
        _LCD_THIRD_ROW -> Ýmleci 3.Satýra taþýr.
        _LCD_FOURTH_ROW -> Ýmleci 4.Satýra taþýr
        _LCD_CLEAR -> Ekraný temizler.
        _LCD_RETURN_HOME -> Ýmleci orjinal pozisyonuna taþýr.(1 Sütun.)
        _LCD_CURSOR_OFF -> Ýmleci kapatýr.
        _LCD_UNDERLINE_ON -> Ýmlecin altýna alt çizgi ekler.
        _LCD_BLINK_CURSOR_ON -> Ýmlecin yanýp sönmesini saðlar.
        _LCD_MOVE_CURSOR_LEFT -> Ýmleci bir sola taþýr.
        _LCD_MOVE_CURSOR_RIGHT -> Ýmleci bir saða taþýr.
        _LCD_TURN_ON -> Lcd display ekranýný açar.
        _LCD_TURN_OFF -> Lcd display ekranýný kapatýr.
        _LCD_SHIFT_LEFT -> Displaydeki verileri sola kaydýrýr.
        _LCD_SHIFT_RIGHT -> Displaydeki verileri saða kaydýrýr.
    NOT: Bizim lcd 2 satýr 16 sütundan oluþur 16x2
*/

unsigned short int isDisplay = 0;
unsigned char selection;

void main() 
{
    trisb.rb0 = trisb.rb1 = 1;
    portb.rb0 = portb.rb1 = 1;
    Lcd_Init(); /*Displayi hazýrladýk.*/
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