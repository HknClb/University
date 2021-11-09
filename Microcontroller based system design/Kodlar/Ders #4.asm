
_main:

;Ders #4.c,46 :: 		void main()
;Ders #4.c,48 :: 		trisb.rb0 = trisb.rb1 = 1;
	BSF        TRISB+0, 1
	BTFSC      TRISB+0, 1
	GOTO       L__main13
	BCF        TRISB+0, 0
	GOTO       L__main14
L__main13:
	BSF        TRISB+0, 0
L__main14:
;Ders #4.c,49 :: 		portb.rb0 = portb.rb1 = 1;
	BSF        PORTB+0, 1
	BTFSC      PORTB+0, 1
	GOTO       L__main15
	BCF        PORTB+0, 0
	GOTO       L__main16
L__main15:
	BSF        PORTB+0, 0
L__main16:
;Ders #4.c,50 :: 		Lcd_Init(); /*Displayi hazýrladýk.*/
	CALL       _Lcd_Init+0
;Ders #4.c,51 :: 		do
L_main0:
;Ders #4.c,53 :: 		if(!isDisplay)
	MOVF       _isDisplay+0, 0
	BTFSS      STATUS+0, 2
	GOTO       L_main3
;Ders #4.c,55 :: 		Lcd_Cmd(_LCD_BLINK_CURSOR_ON);
	MOVLW      15
	MOVWF      FARG_Lcd_Cmd_out_char+0
	CALL       _Lcd_Cmd+0
;Ders #4.c,56 :: 		Lcd_Cmd(_LCD_CLEAR);
	MOVLW      1
	MOVWF      FARG_Lcd_Cmd_out_char+0
	CALL       _Lcd_Cmd+0
;Ders #4.c,57 :: 		Lcd_Out_Cp("Hakan");
	MOVLW      ?lstr1_Ders_32#4+0
	MOVWF      FARG_Lcd_Out_CP_text+0
	CALL       _Lcd_Out_CP+0
;Ders #4.c,58 :: 		delay_ms(750);
	MOVLW      4
	MOVWF      R11+0
	MOVLW      207
	MOVWF      R12+0
	MOVLW      1
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
;Ders #4.c,59 :: 		Lcd_Out(2, 6, " CELEBI");
	MOVLW      2
	MOVWF      FARG_Lcd_Out_row+0
	MOVLW      6
	MOVWF      FARG_Lcd_Out_column+0
	MOVLW      ?lstr2_Ders_32#4+0
	MOVWF      FARG_Lcd_Out_text+0
	CALL       _Lcd_Out+0
;Ders #4.c,60 :: 		Lcd_Cmd(_LCD_CURSOR_OFF);
	MOVLW      12
	MOVWF      FARG_Lcd_Cmd_out_char+0
	CALL       _Lcd_Cmd+0
;Ders #4.c,61 :: 		isDisplay = 1;
	MOVLW      1
	MOVWF      _isDisplay+0
;Ders #4.c,62 :: 		}
L_main3:
;Ders #4.c,63 :: 		if(!portb.rb0)
	BTFSC      PORTB+0, 0
	GOTO       L_main5
;Ders #4.c,65 :: 		Lcd_Cmd(_LCD_CLEAR);
	MOVLW      1
	MOVWF      FARG_Lcd_Cmd_out_char+0
	CALL       _Lcd_Cmd+0
;Ders #4.c,66 :: 		Lcd_Out_Cp("Lcd Cleaned !");
	MOVLW      ?lstr3_Ders_32#4+0
	MOVWF      FARG_Lcd_Out_CP_text+0
	CALL       _Lcd_Out_CP+0
;Ders #4.c,67 :: 		delay_ms(1000);
	MOVLW      6
	MOVWF      R11+0
	MOVLW      19
	MOVWF      R12+0
	MOVLW      173
	MOVWF      R13+0
L_main6:
	DECFSZ     R13+0, 1
	GOTO       L_main6
	DECFSZ     R12+0, 1
	GOTO       L_main6
	DECFSZ     R11+0, 1
	GOTO       L_main6
	NOP
	NOP
;Ders #4.c,68 :: 		Lcd_Cmd(_LCD_CLEAR);
	MOVLW      1
	MOVWF      FARG_Lcd_Cmd_out_char+0
	CALL       _Lcd_Cmd+0
;Ders #4.c,69 :: 		Lcd_Cmd(_LCD_TURN_OFF);
	MOVLW      8
	MOVWF      FARG_Lcd_Cmd_out_char+0
	CALL       _Lcd_Cmd+0
;Ders #4.c,70 :: 		while(!portb.rb0);
L_main7:
	BTFSC      PORTB+0, 0
	GOTO       L_main8
	GOTO       L_main7
L_main8:
;Ders #4.c,71 :: 		}
L_main5:
;Ders #4.c,72 :: 		if(!portb.rb1)
	BTFSC      PORTB+0, 1
	GOTO       L_main9
;Ders #4.c,74 :: 		Lcd_Cmd(_LCD_CLEAR);
	MOVLW      1
	MOVWF      FARG_Lcd_Cmd_out_char+0
	CALL       _Lcd_Cmd+0
;Ders #4.c,75 :: 		Lcd_Cmd(_LCD_TURN_ON);
	MOVLW      12
	MOVWF      FARG_Lcd_Cmd_out_char+0
	CALL       _Lcd_Cmd+0
;Ders #4.c,76 :: 		isDisplay = 0;
	CLRF       _isDisplay+0
;Ders #4.c,77 :: 		while(!portb.rb1);
L_main10:
	BTFSC      PORTB+0, 1
	GOTO       L_main11
	GOTO       L_main10
L_main11:
;Ders #4.c,78 :: 		}
L_main9:
;Ders #4.c,80 :: 		}while(1);
	GOTO       L_main0
;Ders #4.c,82 :: 		}
L_end_main:
	GOTO       $+0
; end of _main
