/*Timer0
TOCS: Timer osilatör seçimi (0->dahili, 1->harici)

TOSE: Timer kenar seçimi (0->düþen kenar, 1->yükselen kenar)

PSA: Frekans bölücü seçimi (0->prescaler timer0, 1->wdt(watch dog timer))

PS2 - PS1 - PS0: (Doðruluk tablosu oluþtur ve sonuçlarda wdt ve prescaler bulunsun. Prescaler ilk satýrdan son satýra n = 1; 2^n++ ile artarken, wdt ilk satýrdan son satýra
n = 0; 2^n++ ile deðer alýr.) Timer0 maximum 256 ya kadar tik alabilmektedir ve ara deðer verilmek istenebilir bu yüzden bunlar kullanýlýr.
  PS2    PS1    PS0    Prescaler    WDT
   0      0      0        2         1
   0      0      1        4         2
   0      1      0        8         4
   0      1      1        16        8
   1      0      0        32        16
   1      0      1        64        32
   1      1      0        128       64
   1      1      1        256       128

TMR0IE: Timer0 için kesmelere izin verilecek mi? (0->izin ver, 1->izin verme)

TMR0IF: Timer0 için eðer kesme yaþandýysa, bu kesme bayraðý true deðerini alýr.
*/

short int counter;

void interrupt()
{
    if(tmr0if_bit == 1)
    {
        counter++;;
        tmr0 = 158;
        tmr0if_bit = 0;
    }
}

void main()
{
    trisb = portb = counter = 0;
    portb.rb0 = 0;
    option_reg = 0xC7;
    intcon = 0xC0;
    tmr0ie_bit = 1;
    tmr0if_bit = 0; /*Kesme bayraðýný her ihtimale karþý temizledik.*/
    tmr0 = 158;
    while(1)
    {
        if(counter >= 100)
        {
            counter = 0;
            portb.rb0 = ~portb.rb0;
        }
    }
}