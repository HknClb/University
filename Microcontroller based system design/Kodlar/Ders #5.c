void interrupt()
{
    if(intcon.intf == 1)
    {
        intcon.gie = 0;
        portb.rb1 = ~portb.rb1;
        intcon.intf = 0;
        intcon.inte = 1;
    }
}

void main() 
{
    trisb = 0x01; /*1. portu yani rb0 portunu giri� olarak ayarlad�k. Di�erlerini ��k�� olarak ayarlad�k.*/
    portb.rb1 = 1; /*Portb.rb1 in de�erini lojik 0 yapt�k.*/
    intcon.intf = 0; /*rb0/int kesme bayra�� temizleniyor.*/
    intcon.inte = 1; /*rb0/int kesme izin veriliyor.*/
    intcon.gie = 1; /*T�m kesme i�lemlerine izin veriliyor.*/
    intcon.peie = 0; /*�evre arabirimlerden kesmelere izin verilmiyor.*/
    option_reg.intedg = 0; /*Y�kselen kenarda kesme olacak. (1 ise y�kselen kenarda 0 ise d��en kenarda)*/
    while(1); /*��emci sonsuz while ile bekletiliyor.*/
}