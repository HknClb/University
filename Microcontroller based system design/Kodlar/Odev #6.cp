#line 1 "C:/Users/hkncl/Desktop/Bahar Yarýyýlý  4.Dönem Derser/Mikrokontrol Tabanlý Sistem Tasarýmý/Kodlar/Odev #6.c"


unsigned short int time;

void interrupt()
{
 if(pir1.tmr1if)
 {
 time++;

 tmr1h = 0x9E;
 tmr1l = 0x58;
 pir1.tmr1if = 0;
 }
}

void main()
{

 time = trisb = portb = 0;

 tmr1h = 0x9E;
 tmr1l = 0x58;

 t1con.t1ckps1 = t1con.t1ckps0 = 1;

 t1con.t1oscen = 0;

 t1con.tmr1cs = 0;

 t1con.tmr1on = 1;

 intcon = 0xC0;

 pie1.tmr1ie = 1;
 pir1.tmr1if = 0;
 while(1)
 {
 switch(time)
 {
 case 50:
 portb = 0x03;
 break;
 case 100:
 portb = 0x0C;
 break;
 case 150:
 portb = 0x30;
 break;
 case 200:
 portb = 0xC0;
 time = 0;
 break;
 }
 }
 while(1);
}
