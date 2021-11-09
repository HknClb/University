
_interrupt:
	MOVWF      R15+0
	SWAPF      STATUS+0, 0
	CLRF       STATUS+0
	MOVWF      ___saveSTATUS+0
	MOVF       PCLATH+0, 0
	MOVWF      ___savePCLATH+0
	CLRF       PCLATH+0

;Ders #6.c,1 :: 		void interrupt(void)
;Ders #6.c,3 :: 		if(intcon.rbif)
	BTFSS      INTCON+0, 0
	GOTO       L_interrupt0
;Ders #6.c,5 :: 		intcon.gie = 0;
	BCF        INTCON+0, 7
;Ders #6.c,6 :: 		if(portb.rb4)
	BTFSS      PORTB+0, 4
	GOTO       L_interrupt1
;Ders #6.c,7 :: 		portb.rb0 = ~portb.rb0;
	MOVLW      1
	XORWF      PORTB+0, 1
	GOTO       L_interrupt2
L_interrupt1:
;Ders #6.c,8 :: 		else if(portb.rb5)
	BTFSS      PORTB+0, 5
	GOTO       L_interrupt3
;Ders #6.c,9 :: 		portb.rb1 = ~portb.rb1;
	MOVLW      2
	XORWF      PORTB+0, 1
L_interrupt3:
L_interrupt2:
;Ders #6.c,10 :: 		if(portb.rb6)
	BTFSS      PORTB+0, 6
	GOTO       L_interrupt4
;Ders #6.c,11 :: 		portb.rb2 = ~portb.rb2;
	MOVLW      4
	XORWF      PORTB+0, 1
L_interrupt4:
;Ders #6.c,12 :: 		if(portb.rb7)
	BTFSS      PORTB+0, 7
	GOTO       L_interrupt5
;Ders #6.c,13 :: 		portb.rb3 = ~portb.rb3;
	MOVLW      8
	XORWF      PORTB+0, 1
L_interrupt5:
;Ders #6.c,14 :: 		}
L_interrupt0:
;Ders #6.c,15 :: 		intcon.rbif = 0;
	BCF        INTCON+0, 0
;Ders #6.c,16 :: 		intcon.gie = 1;
	BSF        INTCON+0, 7
;Ders #6.c,17 :: 		}
L_end_interrupt:
L__interrupt9:
	MOVF       ___savePCLATH+0, 0
	MOVWF      PCLATH+0
	SWAPF      ___saveSTATUS+0, 0
	MOVWF      STATUS+0
	SWAPF      R15+0, 1
	SWAPF      R15+0, 0
	RETFIE
; end of _interrupt

_main:

;Ders #6.c,19 :: 		void main(void)
;Ders #6.c,21 :: 		trisb = 0XF0;
	MOVLW      240
	MOVWF      TRISB+0
;Ders #6.c,22 :: 		portb = 0;
	CLRF       PORTB+0
;Ders #6.c,23 :: 		intcon.rbif = 0;
	BCF        INTCON+0, 0
;Ders #6.c,24 :: 		intcon.rbie = 1;
	BSF        INTCON+0, 3
;Ders #6.c,25 :: 		intcon.gie = 1;
	BSF        INTCON+0, 7
;Ders #6.c,26 :: 		intcon.peie = 0;
	BCF        INTCON+0, 6
;Ders #6.c,27 :: 		while(1);
L_main6:
	GOTO       L_main6
;Ders #6.c,28 :: 		}
L_end_main:
	GOTO       $+0
; end of _main
