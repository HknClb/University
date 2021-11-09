/*Kesme zaman� = 100ms*/

unsigned short int time;

void interrupt()
{
    if(pir1.tmr1if) /*timer kesmesi olmu� ise*/
    {
        time++;
        /*Tekrardan tmr1h ile tmr1l �nde�er y�kleniyor.*/
        tmr1h = 0x9E;
        tmr1l = 0x58;
        pir1.tmr1if = 0; /*Kesme bayra�� temizleniyor.*/
    }
}

void main() 
{
    /*time de�i�keni 0 yap�l�yor ve b portu ��k�� yap�l�p temizleniyor.*/
    time = trisb = portb = 0;
    /*tmr1h ile tmr1l �nde�er y�kleniyor. (0xFFE1 = 40536 -> kesme zaman� form�l�ne koyulursa = 100ms)*/
    tmr1h = 0x9E;
    tmr1l = 0x58;
    /*Giri� sinyalinin prescaler oran� 11 se�iliyor. (1:8)*/
    t1con.t1ckps1 = t1con.t1ckps0 = 1;
    /*Timer1 osilat�r kayna�� pasif yap�l�yor.*/
    t1con.t1oscen = 0;
    /*Dahili osilat�r kullan�m� se�iliyor.*/
    t1con.tmr1cs = 0;
    /*Timer1 aktif yap�l�yor.*/
    t1con.tmr1on = 1;
    /*GIE ve PEIE kuruldu.*/
    intcon = 0xC0;
    /*Timer1 kesmeleri aktif yap�l�yor ve Timer1 kesme bayra�� temizleniyor.*/
    pie1.tmr1ie = 1;
    pir1.tmr1if = 0;
    while(1)
    {
        switch(time)
        {
            case 50: /*5 sn*/
                   portb = 0x03; /*Sa�dan ilk iki led*/
                break;
            case 100: /*10 sn*/
                   portb = 0x0C; /*Sa�dan ikinci iki led*/
                break;
            case 150: /*15 sn*/
                   portb = 0x30; /*Sa�dan ���nc� iki led*/
                break;
            case 200: /*20 sn*/
                   portb = 0xC0; /*Sa�dan d�rd�nc� iki led*/
                   time = 0;
                break;
        }
    }
    while(1);
}