#define arttir PORTC.RC0
#define azalt PORTC.RC1

short display = 0;

void main()
{
    trisb = 0;
    portb = 0;
    trisc = 0x03;
    portc = 0;
    while(1)
    {
        if(!arttir)
        {
            display++;
            while(!arttir);
        }
        if(!azalt)
        {
            display--;
            while(!azalt);
        }
        if(display > 99)
            display = 0;
        else if(display < 0)
            display = 99;
        portb = dec2bcd(display);
    }
}