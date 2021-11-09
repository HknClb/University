void interrupt(void)
{
    if(intcon.rbif)
    {
        intcon.gie = 0;
        if(portb.rb4)
            portb.rb0 = ~portb.rb0;
        else if(portb.rb5)
            portb.rb1 = ~portb.rb1;
        if(portb.rb6)
            portb.rb2 = ~portb.rb2;
        if(portb.rb7)
            portb.rb3 = ~portb.rb3;
    }
    portb = portb;
    intcon.rbif = 0;
    intcon.gie = 1;
}

void main(void)
{
    trisb = 0XF0;
    portb = 0;
    intcon.rbif = 0;
    intcon.rbie = 1;
    intcon.gie = 1;
    intcon.peie = 0;
    while(1);
}