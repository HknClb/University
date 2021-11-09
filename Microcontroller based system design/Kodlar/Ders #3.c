#define arttir PORTC.RC0
#define azalt PORTC.RC1

short display = 0;

void main() 
{
    trisb = 0; /*b portunu çýkýþ olarak ayarladýk.*/
    portb = 0; /*b portunun tüm pinlerinin deðerlerini logic-0 yaptýk.*/
    trisc = 0x03; /*rc0 ve rc1 pinlerini giriþ yapýldý.*/
    portc = 0; /*c portunun tüm pinlerinin deðerlerini logic-0 yaptýk*/
    while(1)
    {
        if(!arttir) /*rc0 portu 0 mý diye kontrol ettik, butona basýldýðý anda anahtar kapanýr ve topraða gider çünkü, akým dirençiz yolu seçer.*/
        {
            display++;
            while(!arttir); /*Butona basýldýp çekildikten sonra buton bir miktar daha basýlý kalýr burada basýldýktan sonra çekilmesi bekleniyor.*/
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
        portb = display; /*Önceden hexadecimal kodlarý ile ayarlýyorduk bu yeni ttl 7748 driveri ile direkt onluk tabanda iþlem yapabiliyoruz.*/
    }
}