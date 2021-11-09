
_main:

;Odev #3.c,6 :: 		void main()
;Odev #3.c,8 :: 		trisb = 0;
	CLRF       TRISB+0
;Odev #3.c,9 :: 		portb = 0;
	CLRF       PORTB+0
;Odev #3.c,10 :: 		trisc = 0x03;
	MOVLW      3
	MOVWF      TRISC+0
;Odev #3.c,11 :: 		portc = 0;
	CLRF       PORTC+0
;Odev #3.c,12 :: 		while(1)
L_main0:
;Odev #3.c,14 :: 		if(!arttir)
	BTFSC      PORTC+0, 0
	GOTO       L_main2
;Odev #3.c,16 :: 		display++;
	INCF       _display+0, 1
;Odev #3.c,17 :: 		while(!arttir);
L_main3:
	BTFSC      PORTC+0, 0
	GOTO       L_main4
	GOTO       L_main3
L_main4:
;Odev #3.c,18 :: 		}
L_main2:
;Odev #3.c,19 :: 		if(!azalt)
	BTFSC      PORTC+0, 1
	GOTO       L_main5
;Odev #3.c,21 :: 		display--;
	DECF       _display+0, 1
;Odev #3.c,22 :: 		while(!azalt);
L_main6:
	BTFSC      PORTC+0, 1
	GOTO       L_main7
	GOTO       L_main6
L_main7:
;Odev #3.c,23 :: 		}
L_main5:
;Odev #3.c,24 :: 		if(display > 99)
	MOVLW      128
	XORLW      99
	MOVWF      R0+0
	MOVLW      128
	XORWF      _display+0, 0
	SUBWF      R0+0, 0
	BTFSC      STATUS+0, 0
	GOTO       L_main8
;Odev #3.c,25 :: 		display = 0;
	CLRF       _display+0
	GOTO       L_main9
L_main8:
;Odev #3.c,26 :: 		else if(display < 0)
	MOVLW      128
	XORWF      _display+0, 0
	MOVWF      R0+0
	MOVLW      128
	XORLW      0
	SUBWF      R0+0, 0
	BTFSC      STATUS+0, 0
	GOTO       L_main10
;Odev #3.c,27 :: 		display = 99;
	MOVLW      99
	MOVWF      _display+0
L_main10:
L_main9:
;Odev #3.c,28 :: 		portb = dec2bcd(display);
	MOVF       _display+0, 0
	MOVWF      FARG_Dec2Bcd_decnum+0
	CALL       _Dec2Bcd+0
	MOVF       R0+0, 0
	MOVWF      PORTB+0
;Odev #3.c,29 :: 		}
	GOTO       L_main0
;Odev #3.c,30 :: 		}
L_end_main:
	GOTO       $+0
; end of _main
