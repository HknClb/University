/*Kesme zamaný = 100ms*/

unsigned short int time;

void interrupt()
{
    if(pir1.tmr1if) /*timer kesmesi olmuþ ise*/
    {
        time++;
        /*Tekrardan tmr1h ile tmr1l öndeðer yükleniyor.*/
        tmr1h = 0x9E;
        tmr1l = 0x58;
        pir1.tmr1if = 0; /*Kesme bayraðý temizleniyor.*/
    }
}

void main() 
{
    /*time deðiþkeni 0 yapýlýyor ve b portu çýkýþ yapýlýp temizleniyor.*/
    time = trisb = portb = 0;
    /*tmr1h ile tmr1l öndeðer yükleniyor. (0xFFE1 = 40536 -> kesme zamaný formülüne koyulursa = 100ms)*/
    tmr1h = 0x9E;
    tmr1l = 0x58;
    /*Giriþ sinyalinin prescaler oraný 11 seçiliyor. (1:8)*/
    t1con.t1ckps1 = t1con.t1ckps0 = 1;
    /*Timer1 osilatör kaynaðý pasif yapýlýyor.*/
    t1con.t1oscen = 0;
    /*Dahili osilatör kullanýmý seçiliyor.*/
    t1con.tmr1cs = 0;
    /*Timer1 aktif yapýlýyor.*/
    t1con.tmr1on = 1;
    /*GIE ve PEIE kuruldu.*/
    intcon = 0xC0;
    /*Timer1 kesmeleri aktif yapýlýyor ve Timer1 kesme bayraðý temizleniyor.*/
    pie1.tmr1ie = 1;
    pir1.tmr1if = 0;
    while(1)
    {
        switch(time)
        {
            case 50: /*5 sn*/
                   portb = 0x03; /*Saðdan ilk iki led*/
                break;
            case 100: /*10 sn*/
                   portb = 0x0C; /*Saðdan ikinci iki led*/
                break;
            case 150: /*15 sn*/
                   portb = 0x30; /*Saðdan üçüncü iki led*/
                break;
            case 200: /*20 sn*/
                   portb = 0xC0; /*Saðdan dördüncü iki led*/
                   time = 0;
                break;
        }
    }
    while(1);
}