
_main:

;Odev #2.c,1 :: 		void main()
;Odev #2.c,4 :: 		unsigned short i = 0;
	CLRF       main_i_L0+0
;Odev #2.c,5 :: 		trisb = 0;
	CLRF       TRISB+0
;Odev #2.c,6 :: 		portb = display[i];
	MOVF       main_i_L0+0, 0
	MOVWF      R0+0
	CLRF       R0+1
	RLF        R0+0, 1
	RLF        R0+1, 1
	BCF        R0+0, 0
	MOVLW      main_display_L0+0
	ADDWF      R0+0, 1
	MOVLW      hi_addr(main_display_L0+0)
	BTFSC      STATUS+0, 0
	ADDLW      1
	ADDWF      R0+1, 1
	MOVF       R0+0, 0
	MOVWF      ___DoICPAddr+0
	MOVF       R0+1, 0
	MOVWF      ___DoICPAddr+1
	CALL       _____DoICP+0
	MOVWF      PORTB+0
;Odev #2.c,7 :: 		trisd.rd0 = trisd.rd1 = 1;
	BSF        TRISD+0, 1
	BTFSC      TRISD+0, 1
	GOTO       L__main11
	BCF        TRISD+0, 0
	GOTO       L__main12
L__main11:
	BSF        TRISD+0, 0
L__main12:
;Odev #2.c,8 :: 		portd.rd0 = portd.rd1 = 0;
	BCF        PORTD+0, 1
	BTFSC      PORTD+0, 1
	GOTO       L__main13
	BCF        PORTD+0, 0
	GOTO       L__main14
L__main13:
	BSF        PORTD+0, 0
L__main14:
;Odev #2.c,9 :: 		while(1)
L_main0:
;Odev #2.c,11 :: 		if(portd.rd0)
	BTFSS      PORTD+0, 0
	GOTO       L_main2
;Odev #2.c,13 :: 		if(i != 9)
	MOVF       main_i_L0+0, 0
	XORLW      9
	BTFSC      STATUS+0, 2
	GOTO       L_main3
;Odev #2.c,14 :: 		portb = display[++i];
	INCF       main_i_L0+0, 1
	MOVF       main_i_L0+0, 0
	MOVWF      R0+0
	CLRF       R0+1
	RLF        R0+0, 1
	RLF        R0+1, 1
	BCF        R0+0, 0
	MOVLW      main_display_L0+0
	ADDWF      R0+0, 1
	MOVLW      hi_addr(main_display_L0+0)
	BTFSC      STATUS+0, 0
	ADDLW      1
	ADDWF      R0+1, 1
	MOVF       R0+0, 0
	MOVWF      ___DoICPAddr+0
	MOVF       R0+1, 0
	MOVWF      ___DoICPAddr+1
	CALL       _____DoICP+0
	MOVWF      PORTB+0
	GOTO       L_main4
L_main3:
;Odev #2.c,17 :: 		i = 0;
	CLRF       main_i_L0+0
;Odev #2.c,18 :: 		portb = display[i];
	CLRF       R0+0
	CLRF       R0+1
	MOVLW      main_display_L0+0
	ADDWF      R0+0, 1
	MOVLW      hi_addr(main_display_L0+0)
	BTFSC      STATUS+0, 0
	ADDLW      1
	ADDWF      R0+1, 1
	MOVF       R0+0, 0
	MOVWF      ___DoICPAddr+0
	MOVF       R0+1, 0
	MOVWF      ___DoICPAddr+1
	CALL       _____DoICP+0
	MOVWF      PORTB+0
;Odev #2.c,19 :: 		}
L_main4:
;Odev #2.c,21 :: 		delay_ms(300);
	MOVLW      4
	MOVWF      R11+0
	MOVLW      12
	MOVWF      R12+0
	MOVLW      51
	MOVWF      R13+0
L_main5:
	DECFSZ     R13+0, 1
	GOTO       L_main5
	DECFSZ     R12+0, 1
	GOTO       L_main5
	DECFSZ     R11+0, 1
	GOTO       L_main5
	NOP
	NOP
;Odev #2.c,22 :: 		}
L_main2:
;Odev #2.c,23 :: 		if(portd.rd1)
	BTFSS      PORTD+0, 1
	GOTO       L_main6
;Odev #2.c,25 :: 		if(i != 0)
	MOVF       main_i_L0+0, 0
	XORLW      0
	BTFSC      STATUS+0, 2
	GOTO       L_main7
;Odev #2.c,26 :: 		portb = display[--i];
	DECF       main_i_L0+0, 1
	MOVF       main_i_L0+0, 0
	MOVWF      R0+0
	CLRF       R0+1
	RLF        R0+0, 1
	RLF        R0+1, 1
	BCF        R0+0, 0
	MOVLW      main_display_L0+0
	ADDWF      R0+0, 1
	MOVLW      hi_addr(main_display_L0+0)
	BTFSC      STATUS+0, 0
	ADDLW      1
	ADDWF      R0+1, 1
	MOVF       R0+0, 0
	MOVWF      ___DoICPAddr+0
	MOVF       R0+1, 0
	MOVWF      ___DoICPAddr+1
	CALL       _____DoICP+0
	MOVWF      PORTB+0
	GOTO       L_main8
L_main7:
;Odev #2.c,29 :: 		i = 9;
	MOVLW      9
	MOVWF      main_i_L0+0
;Odev #2.c,30 :: 		portb = display[i];
	MOVLW      18
	MOVWF      R0+0
	MOVLW      0
	MOVWF      R0+1
	MOVLW      main_display_L0+0
	ADDWF      R0+0, 1
	MOVLW      hi_addr(main_display_L0+0)
	BTFSC      STATUS+0, 0
	ADDLW      1
	ADDWF      R0+1, 1
	MOVF       R0+0, 0
	MOVWF      ___DoICPAddr+0
	MOVF       R0+1, 0
	MOVWF      ___DoICPAddr+1
	CALL       _____DoICP+0
	MOVWF      PORTB+0
;Odev #2.c,31 :: 		}
L_main8:
;Odev #2.c,32 :: 		delay_ms(300);
	MOVLW      4
	MOVWF      R11+0
	MOVLW      12
	MOVWF      R12+0
	MOVLW      51
	MOVWF      R13+0
L_main9:
	DECFSZ     R13+0, 1
	GOTO       L_main9
	DECFSZ     R12+0, 1
	GOTO       L_main9
	DECFSZ     R11+0, 1
	GOTO       L_main9
	NOP
	NOP
;Odev #2.c,33 :: 		}
L_main6:
;Odev #2.c,34 :: 		}
	GOTO       L_main0
;Odev #2.c,35 :: 		}
L_end_main:
	GOTO       $+0
; end of _main
