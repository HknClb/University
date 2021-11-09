
_main:

;Odev #1.c,1 :: 		void main()
;Odev #1.c,3 :: 		ADCON1 |= 0X0f;
	MOVLW      15
	IORWF      ADCON1+0, 1
;Odev #1.c,4 :: 		trisb = 0;
	CLRF       TRISB+0
;Odev #1.c,5 :: 		portb = 0;
	CLRF       PORTB+0
;Odev #1.c,6 :: 		while(0 == 0)
L_main0:
;Odev #1.c,8 :: 		portb.b7 = 1;
	BSF        PORTB+0, 7
;Odev #1.c,9 :: 		delay_ms(500);
	MOVLW      13
	MOVWF      R11+0
	MOVLW      175
	MOVWF      R12+0
	MOVLW      182
	MOVWF      R13+0
L_main2:
	DECFSZ     R13+0, 1
	GOTO       L_main2
	DECFSZ     R12+0, 1
	GOTO       L_main2
	DECFSZ     R11+0, 1
	GOTO       L_main2
	NOP
;Odev #1.c,10 :: 		portb.b7 = 0;
	BCF        PORTB+0, 7
;Odev #1.c,11 :: 		portb.b6 = 1;
	BSF        PORTB+0, 6
;Odev #1.c,12 :: 		delay_ms(500);
	MOVLW      13
	MOVWF      R11+0
	MOVLW      175
	MOVWF      R12+0
	MOVLW      182
	MOVWF      R13+0
L_main3:
	DECFSZ     R13+0, 1
	GOTO       L_main3
	DECFSZ     R12+0, 1
	GOTO       L_main3
	DECFSZ     R11+0, 1
	GOTO       L_main3
	NOP
;Odev #1.c,13 :: 		portb.b6 = 0;
	BCF        PORTB+0, 6
;Odev #1.c,14 :: 		portb.b5 = 1;
	BSF        PORTB+0, 5
;Odev #1.c,15 :: 		delay_ms(500);
	MOVLW      13
	MOVWF      R11+0
	MOVLW      175
	MOVWF      R12+0
	MOVLW      182
	MOVWF      R13+0
L_main4:
	DECFSZ     R13+0, 1
	GOTO       L_main4
	DECFSZ     R12+0, 1
	GOTO       L_main4
	DECFSZ     R11+0, 1
	GOTO       L_main4
	NOP
;Odev #1.c,16 :: 		portb.b5 = 0;
	BCF        PORTB+0, 5
;Odev #1.c,17 :: 		portb.b4 = 1;
	BSF        PORTB+0, 4
;Odev #1.c,18 :: 		delay_ms(500);
	MOVLW      13
	MOVWF      R11+0
	MOVLW      175
	MOVWF      R12+0
	MOVLW      182
	MOVWF      R13+0
L_main5:
	DECFSZ     R13+0, 1
	GOTO       L_main5
	DECFSZ     R12+0, 1
	GOTO       L_main5
	DECFSZ     R11+0, 1
	GOTO       L_main5
	NOP
;Odev #1.c,19 :: 		portb.b4 = 0;
	BCF        PORTB+0, 4
;Odev #1.c,20 :: 		portb.b3 = 1;
	BSF        PORTB+0, 3
;Odev #1.c,21 :: 		delay_ms(500);
	MOVLW      13
	MOVWF      R11+0
	MOVLW      175
	MOVWF      R12+0
	MOVLW      182
	MOVWF      R13+0
L_main6:
	DECFSZ     R13+0, 1
	GOTO       L_main6
	DECFSZ     R12+0, 1
	GOTO       L_main6
	DECFSZ     R11+0, 1
	GOTO       L_main6
	NOP
;Odev #1.c,22 :: 		portb.b3 = 0;
	BCF        PORTB+0, 3
;Odev #1.c,23 :: 		portb.b2 = 1;
	BSF        PORTB+0, 2
;Odev #1.c,24 :: 		delay_ms(500);
	MOVLW      13
	MOVWF      R11+0
	MOVLW      175
	MOVWF      R12+0
	MOVLW      182
	MOVWF      R13+0
L_main7:
	DECFSZ     R13+0, 1
	GOTO       L_main7
	DECFSZ     R12+0, 1
	GOTO       L_main7
	DECFSZ     R11+0, 1
	GOTO       L_main7
	NOP
;Odev #1.c,25 :: 		portb.b2 = 0;
	BCF        PORTB+0, 2
;Odev #1.c,26 :: 		portb.b1 = 1;
	BSF        PORTB+0, 1
;Odev #1.c,27 :: 		delay_ms(500);
	MOVLW      13
	MOVWF      R11+0
	MOVLW      175
	MOVWF      R12+0
	MOVLW      182
	MOVWF      R13+0
L_main8:
	DECFSZ     R13+0, 1
	GOTO       L_main8
	DECFSZ     R12+0, 1
	GOTO       L_main8
	DECFSZ     R11+0, 1
	GOTO       L_main8
	NOP
;Odev #1.c,28 :: 		portb.b1 = 0;
	BCF        PORTB+0, 1
;Odev #1.c,29 :: 		portb.b0 = 1;
	BSF        PORTB+0, 0
;Odev #1.c,30 :: 		delay_ms(500);
	MOVLW      13
	MOVWF      R11+0
	MOVLW      175
	MOVWF      R12+0
	MOVLW      182
	MOVWF      R13+0
L_main9:
	DECFSZ     R13+0, 1
	GOTO       L_main9
	DECFSZ     R12+0, 1
	GOTO       L_main9
	DECFSZ     R11+0, 1
	GOTO       L_main9
	NOP
;Odev #1.c,31 :: 		portb.b0 = 0;
	BCF        PORTB+0, 0
;Odev #1.c,32 :: 		}
	GOTO       L_main0
;Odev #1.c,33 :: 		}
L_end_main:
	GOTO       $+0
; end of _main
