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
    trisb = 0x01; /*1. portu yani rb0 portunu giriþ olarak ayarladýk. Diðerlerini çýkýþ olarak ayarladýk.*/
    portb.rb1 = 1; /*Portb.rb1 in deðerini lojik 0 yaptýk.*/
    intcon.intf = 0; /*rb0/int kesme bayraðý temizleniyor.*/
    intcon.inte = 1; /*rb0/int kesme izin veriliyor.*/
    intcon.gie = 1; /*Tüm kesme iþlemlerine izin veriliyor.*/
    intcon.peie = 0; /*Çevre arabirimlerden kesmelere izin verilmiyor.*/
    option_reg.intedg = 0; /*Yükselen kenarda kesme olacak. (1 ise yükselen kenarda 0 ise düþen kenarda)*/
    while(1); /*Ýþemci sonsuz while ile bekletiliyor.*/
}