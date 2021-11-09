#define arttir PORTC.RC0
#define azalt PORTC.RC1

short display = 0;

void main() 
{
    trisb = 0; /*b portunu ��k�� olarak ayarlad�k.*/
    portb = 0; /*b portunun t�m pinlerinin de�erlerini logic-0 yapt�k.*/
    trisc = 0x03; /*rc0 ve rc1 pinlerini giri� yap�ld�.*/
    portc = 0; /*c portunun t�m pinlerinin de�erlerini logic-0 yapt�k*/
    while(1)
    {
        if(!arttir) /*rc0 portu 0 m� diye kontrol ettik, butona bas�ld��� anda anahtar kapan�r ve topra�a gider ��nk�, ak�m diren�iz yolu se�er.*/
        {
            display++;
            while(!arttir); /*Butona bas�ld�p �ekildikten sonra buton bir miktar daha bas�l� kal�r burada bas�ld�ktan sonra �ekilmesi bekleniyor.*/
        }
        if(!azalt)
        {
            display--;
            while(!azalt);
        }
        if(display < 0)
            display = 9;
        else if(display > 9)
            display = 0;
        portb = display; /*�nceden hexadecimal kodlar� ile ayarl�yorduk bu yeni ttl 7748 driveri ile direkt onluk tabanda i�lem yapabiliyoruz.*/
    }
}