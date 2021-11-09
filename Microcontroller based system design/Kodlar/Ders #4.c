/*Burada yap�lan i�lemler pinleri birbirlerine e�itlemektir. Yani lcd rs pinini rd2 portuna ba�lad�k gibi.*/

sbit LCD_RS at RD2_bit;
sbit LCD_EN at RD3_bit;
sbit LCD_D4 at RD4_bit;
sbit LCD_D5 at RD5_bit;
sbit LCD_D6 at RD6_bit;
sbit LCD_D7 at RD7_bit;

/*Lcd ��k�� ba�lant�lar�n� porta verdik.*/
sbit LCD_RS_Direction at TRISD2_bit;
sbit LCD_EN_Direction at TRISD3_bit;
sbit LCD_D4_Direction at TRISD4_bit;
sbit LCD_D5_Direction at TRISD5_bit;
sbit LCD_D6_Direction at TRISD6_bit;
sbit LCD_D7_Direction at TRISD7_bit;

/*Baz� temel fonksiyonlar
    -Lcd_Init() -> Lcd display'i kullan�ma haz�r hale getirir. Bunu yapmak zorunday�z.
    -Lcd_Out(1(Sat�r), 3(S�tun), "Merhaba"(Herhangi bir katar)) -> Belirlenen sat�r ve s�tundan ba�layarak verilen katar� ekrana yazd�r�r.
    -Lcd_Out_Cp("Sivas EML") -> �mlecin bulundu�u konumdan ba�layarak belirtilen katar� ekrana yazd�r�r.
    -Lcd_Chr(2, 3, 'H') -> Belirtilen sat�r ve s�tundan ba�layarak verilen karakteri ekrana yazd�r�r.
    -Lcd_Chr_Cp('H') -> �mlecin bulundu�u konumdan ba�layarak karakteri ekrana yazd�r�r.
    -Lcd_Cmd(Komut) -> Parametre olarak girilen komutu i�ler.
        _LCD_FIRST_ROW -> �mleci 1.Sat�ra ta��r.
        _LCD_SECOND_ROW -> �mleci 2.Sat�ra ta��r.
        _LCD_THIRD_ROW -> �mleci 3.Sat�ra ta��r.
        _LCD_FOURTH_ROW -> �mleci 4.Sat�ra ta��r
        _LCD_CLEAR -> Ekran� temizler.
        _LCD_RETURN_HOME -> �mleci orjinal pozisyonuna ta��r.(1 S�tun.)
        _LCD_CURSOR_OFF -> �mleci kapat�r.
        _LCD_UNDERLINE_ON -> �mlecin alt�na alt �izgi ekler.
        _LCD_BLINK_CURSOR_ON -> �mlecin yan�p s�nmesini sa�lar.
        _LCD_MOVE_CURSOR_LEFT -> �mleci bir sola ta��r.
        _LCD_MOVE_CURSOR_RIGHT -> �mleci bir sa�a ta��r.
        _LCD_TURN_ON -> Lcd display ekran�n� a�ar.
        _LCD_TURN_OFF -> Lcd display ekran�n� kapat�r.
        _LCD_SHIFT_LEFT -> Displaydeki verileri sola kayd�r�r.
        _LCD_SHIFT_RIGHT -> Displaydeki verileri sa�a kayd�r�r.
    NOT: Bizim lcd 2 sat�r 16 s�tundan olu�ur 16x2
*/

unsigned short int isDisplay = 0;
unsigned char selection;

void main() 
{
    trisb.rb0 = trisb.rb1 = 1;
    portb.rb0 = portb.rb1 = 1;
    Lcd_Init(); /*Displayi haz�rlad�k.*/
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