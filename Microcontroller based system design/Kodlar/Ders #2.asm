
_main:

;Ders #2.c,1 :: 		void main()
;Ders #2.c,3 :: 		unsigned short i = 0;
	CLRF       main_i_L0+0
;Ders #2.c,5 :: 		trisb = 0;
	CLRF       TRISB+0
;Ders #2.c,6 :: 		portb = 0X3F;
	MOVLW      63
	MOVWF      PORTB+0
;Ders #2.c,7 :: 		for(i = 0; i < 11; i++)
	CLRF       main_i_L0+0
L_main0:
	MOVLW      11
	SUBWF      main_i_L0+0, 0
	BTFSC      STATUS+0, 0
	GOTO       L_main1
;Ders #2.c,9 :: 		if(i == 10)
	MOVF       main_i_L0+0, 0
	XORLW      10
	BTFSS      STATUS+0, 2
	GOTO       L_main3
;Ders #2.c,10 :: 		i = 0;
	CLRF       main_i_L0+0
L_main3:
;Ders #2.c,11 :: 		portb = display[i];
	MOVF       main_i_L0+0, 0
	ADDLW      main_display_L0+0
	MOVWF      R0+0
	MOVLW      hi_addr(main_display_L0+0)
	BTFSC      STATUS+0, 0
	ADDLW      1
	MOVWF      R0+1
	MOVF       R0+0, 0
	MOVWF      ___DoICPAddr+0
	MOVF       R0+1, 0
	MOVWF      ___DoICPAddr+1
	CALL       _____DoICP+0
	MOVWF      PORTB+0
;Ders #2.c,12 :: 		delay_ms(500);
	MOVLW      3
	MOVWF      R11+0
	MOVLW      138
	MOVWF      R12+0
	MOVLW      85
	MOVWF      R13+0
L_main4:
	DECFSZ     R13+0, 1
	GOTO       L_main4
	DECFSZ     R12+0, 1
	GOTO       L_main4
	DECFSZ     R11+0, 1
	GOTO       L_main4
	NOP
	NOP
;Ders #2.c,7 :: 		for(i = 0; i < 11; i++)
	INCF       main_i_L0+0, 1
;Ders #2.c,13 :: 		}
	GOTO       L_main0
L_main1:
;Ders #2.c,14 :: 		}
L_end_main:
	GOTO       $+0
; end of _main
