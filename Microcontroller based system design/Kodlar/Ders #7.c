/*Timer0
TOCS: Timer osilat�r se�imi (0->dahili, 1->harici)

TOSE: Timer kenar se�imi (0->d��en kenar, 1->y�kselen kenar)

PSA: Frekans b�l�c� se�imi (0->prescaler timer0, 1->wdt(watch dog timer))

PS2 - PS1 - PS0: (Do�ruluk tablosu olu�tur ve sonu�larda wdt ve prescaler bulunsun. Prescaler ilk sat�rdan son sat�ra n = 1; 2^n++ ile artarken, wdt ilk sat�rdan son sat�ra
n = 0; 2^n++ ile de�er al�r.) Timer0 maximum 256 ya kadar tik alabilmektedir ve ara de�er verilmek istenebilir bu y�zden bunlar kullan�l�r.
  PS2    PS1    PS0    Prescaler    WDT
   0      0      0        2         1
   0      0      1        4         2
   0      1      0        8         4
   0      1      1        16        8
   1      0      0        32        16
   1      0      1        64        32
   1      1      0        128       64
   1      1      1        256       128

TMR0IE: Timer0 i�in kesmelere izin verilecek mi? (0->izin ver, 1->izin verme)

TMR0IF: Timer0 i�in e�er kesme ya�and�ysa, bu kesme bayra�� true de�erini al�r.
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
    tmr0if_bit = 0; /*Kesme bayra��n� her ihtimale kar�� temizledik.*/
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