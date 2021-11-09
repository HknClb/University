
_interrupt:
	MOVWF      R15+0
	SWAPF      STATUS+0, 0
	CLRF       STATUS+0
	MOVWF      ___saveSTATUS+0
	MOVF       PCLATH+0, 0
	MOVWF      ___savePCLATH+0
	CLRF       PCLATH+0

;Odev #5.c,1 :: 		void interrupt(void)
;Odev #5.c,3 :: 		if(intcon.rbif)
	BTFSS      INTCON+0, 0
	GOTO       L_interrupt0
;Odev #5.c,5 :: 		intcon.gie = 0;
	BCF        INTCON+0, 7
;Odev #5.c,7 :: 		portb = 0;
	CLRF       PORTB+0
;Odev #5.c,8 :: 		if(portb.rb4)
	BTFSS      PORTB+0, 4
	GOTO       L_interrupt1
;Odev #5.c,9 :: 		portb.rb0 = ~portb.rb0;
	MOVLW      1
	XORWF      PORTB+0, 1
	GOTO       L_interrupt2
L_interrupt1:
;Odev #5.c,10 :: 		else if(portb.rb5)
	BTFSS      PORTB+0, 5
	GOTO       L_interrupt3
;Odev #5.c,11 :: 		portb.rb1 = ~portb.rb1;
	MOVLW      2
	XORWF      PORTB+0, 1
	GOTO       L_interrupt4
L_interrupt3:
;Odev #5.c,12 :: 		else if(portb.rb6)
	BTFSS      PORTB+0, 6
	GOTO       L_interrupt5
;Odev #5.c,13 :: 		portb.rb2 = ~portb.rb2;
	MOVLW      4
	XORWF      PORTB+0, 1
	GOTO       L_interrupt6
L_interrupt5:
;Odev #5.c,14 :: 		else if(portb.rb7)
	BTFSS      PORTB+0, 7
	GOTO       L_interrupt7
;Odev #5.c,15 :: 		portb.rb3 = ~portb.rb3;
	MOVLW      8
	XORWF      PORTB+0, 1
L_interrupt7:
L_interrupt6:
L_interrupt4:
L_interrupt2:
;Odev #5.c,16 :: 		}
L_interrupt0:
;Odev #5.c,17 :: 		while(portb.rb4);
L_interrupt8:
	BTFSS      PORTB+0, 4
	GOTO       L_interrupt9
	GOTO       L_interrupt8
L_interrupt9:
;Odev #5.c,18 :: 		while(portb.rb5);
L_interrupt10:
	BTFSS      PORTB+0, 5
	GOTO       L_interrupt11
	GOTO       L_interrupt10
L_interrupt11:
;Odev #5.c,19 :: 		while(portb.rb6);
L_interrupt12:
	BTFSS      PORTB+0, 6
	GOTO       L_interrupt13
	GOTO       L_interrupt12
L_interrupt13:
;Odev #5.c,20 :: 		while(portb.rb7);
L_interrupt14:
	BTFSS      PORTB+0, 7
	GOTO       L_interrupt15
	GOTO       L_interrupt14
L_interrupt15:
;Odev #5.c,21 :: 		portb = portb;
;Odev #5.c,22 :: 		intcon.rbif = 0;
	BCF        INTCON+0, 0
;Odev #5.c,23 :: 		intcon.gie = 1;
	BSF        INTCON+0, 7
;Odev #5.c,24 :: 		}
L_end_interrupt:
L__interrupt19:
	MOVF       ___savePCLATH+0, 0
	MOVWF      PCLATH+0
	SWAPF      ___saveSTATUS+0, 0
	MOVWF      STATUS+0
	SWAPF      R15+0, 1
	SWAPF      R15+0, 0
	RETFIE
; end of _interrupt

_main:

;Odev #5.c,26 :: 		void main(void)
;Odev #5.c,28 :: 		trisb = 0XF0;
	MOVLW      240
	MOVWF      TRISB+0
;Odev #5.c,29 :: 		portb = 0;
	CLRF       PORTB+0
;Odev #5.c,30 :: 		intcon.rbif = 0;
	BCF        INTCON+0, 0
;Odev #5.c,31 :: 		intcon.rbie = 1;
	BSF        INTCON+0, 3
;Odev #5.c,32 :: 		intcon.gie = 1;
	BSF        INTCON+0, 7
;Odev #5.c,33 :: 		intcon.peie = 0;
	BCF        INTCON+0, 6
;Odev #5.c,34 :: 		while(1);
L_main16:
	GOTO       L_main16
;Odev #5.c,35 :: 		}
L_end_main:
	GOTO       $+0
; end of _main
