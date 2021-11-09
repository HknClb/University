
_main:

;Ders #1.c,1 :: 		void main()
;Ders #1.c,3 :: 		trisb = 0;
	CLRF       TRISB+0
;Ders #1.c,4 :: 		portb = 0x0F;
	MOVLW      15
	MOVWF      PORTB+0
;Ders #1.c,5 :: 		trisd.rd0 = 1;
	BSF        TRISD+0, 0
;Ders #1.c,6 :: 		portd.rd0 = 0;
	BCF        PORTD+0, 0
;Ders #1.c,7 :: 		while(1)
L_main0:
;Ders #1.c,9 :: 		if(portd.rd0)
	BTFSS      PORTD+0, 0
	GOTO       L_main2
;Ders #1.c,11 :: 		portb = ~portb;
	COMF       PORTB+0, 1
;Ders #1.c,12 :: 		while(portd.rd0);
L_main3:
	BTFSS      PORTD+0, 0
	GOTO       L_main4
	GOTO       L_main3
L_main4:
;Ders #1.c,13 :: 		}
L_main2:
;Ders #1.c,14 :: 		}
	GOTO       L_main0
;Ders #1.c,15 :: 		}
L_end_main:
	GOTO       $+0
; end of _main
