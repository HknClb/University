
_main:

;Odev #4.c,19 :: 		void main()
;Odev #4.c,21 :: 		trisb = 0x04;
	MOVLW      4
	MOVWF      TRISB+0
;Odev #4.c,22 :: 		portb = 0;
	CLRF       PORTB+0
;Odev #4.c,23 :: 		Lcd_Init(); /*Displayi hazýrladýk.*/
	CALL       _Lcd_Init+0
;Odev #4.c,24 :: 		Lcd_Cmd(_LCD_CLEAR);
	MOVLW      1
	MOVWF      FARG_Lcd_Cmd_out_char+0
	CALL       _Lcd_Cmd+0
;Odev #4.c,25 :: 		Lcd_Out_Cp("PIC16F877A");
	MOVLW      ?lstr1_Odev_32#4+0
	MOVWF      FARG_Lcd_Out_CP_text+0
	CALL       _Lcd_Out_CP+0
;Odev #4.c,26 :: 		Lcd_Out(2, 9, "MICRO-C");
	MOVLW      2
	MOVWF      FARG_Lcd_Out_row+0
	MOVLW      9
	MOVWF      FARG_Lcd_Out_column+0
	MOVLW      ?lstr2_Odev_32#4+0
	MOVWF      FARG_Lcd_Out_text+0
	CALL       _Lcd_Out+0
;Odev #4.c,27 :: 		Lcd_Cmd(_LCD_CURSOR_OFF);
	MOVLW      12
	MOVWF      FARG_Lcd_Cmd_out_char+0
	CALL       _Lcd_Cmd+0
;Odev #4.c,28 :: 		while(1)
L_main0:
;Odev #4.c,30 :: 		if(clear)
	BTFSS      PORTB+0, 1
	GOTO       L_main2
;Odev #4.c,32 :: 		Lcd_Cmd(_LCD_CLEAR);
	MOVLW      1
	MOVWF      FARG_Lcd_Cmd_out_char+0
	CALL       _Lcd_Cmd+0
;Odev #4.c,33 :: 		while(clear);
L_main3:
	BTFSS      PORTB+0, 1
	GOTO       L_main4
	GOTO       L_main3
L_main4:
;Odev #4.c,34 :: 		}
L_main2:
;Odev #4.c,35 :: 		if(write)
	BTFSS      PORTB+0, 0
	GOTO       L_main5
;Odev #4.c,37 :: 		Lcd_Cmd(_LCD_CLEAR);
	MOVLW      1
	MOVWF      FARG_Lcd_Cmd_out_char+0
	CALL       _Lcd_Cmd+0
;Odev #4.c,38 :: 		Lcd_Out_Cp("Hakan");
	MOVLW      ?lstr3_Odev_32#4+0
	MOVWF      FARG_Lcd_Out_CP_text+0
	CALL       _Lcd_Out_CP+0
;Odev #4.c,39 :: 		Lcd_Out(2, 6, "CELEBI");
	MOVLW      2
	MOVWF      FARG_Lcd_Out_row+0
	MOVLW      6
	MOVWF      FARG_Lcd_Out_column+0
	MOVLW      ?lstr4_Odev_32#4+0
	MOVWF      FARG_Lcd_Out_text+0
	CALL       _Lcd_Out+0
;Odev #4.c,40 :: 		while(write);
L_main6:
	BTFSS      PORTB+0, 0
	GOTO       L_main7
	GOTO       L_main6
L_main7:
;Odev #4.c,41 :: 		}
L_main5:
;Odev #4.c,42 :: 		if(shift_left)
	BTFSS      PORTB+0, 2
	GOTO       L_main8
;Odev #4.c,44 :: 		Lcd_Cmd(_LCD_SHIFT_LEFT);
	MOVLW      24
	MOVWF      FARG_Lcd_Cmd_out_char+0
	CALL       _Lcd_Cmd+0
;Odev #4.c,45 :: 		while(shift_left);
L_main9:
	BTFSS      PORTB+0, 2
	GOTO       L_main10
	GOTO       L_main9
L_main10:
;Odev #4.c,46 :: 		}
L_main8:
;Odev #4.c,47 :: 		if(shift_right)
	BTFSS      PORTB+0, 3
	GOTO       L_main11
;Odev #4.c,49 :: 		Lcd_Cmd(_LCD_SHIFT_RIGHT);
	MOVLW      28
	MOVWF      FARG_Lcd_Cmd_out_char+0
	CALL       _Lcd_Cmd+0
;Odev #4.c,50 :: 		while(shift_right);
L_main12:
	BTFSS      PORTB+0, 3
	GOTO       L_main13
	GOTO       L_main12
L_main13:
;Odev #4.c,51 :: 		}
L_main11:
;Odev #4.c,52 :: 		}
	GOTO       L_main0
;Odev #4.c,53 :: 		}
L_end_main:
	GOTO       $+0
; end of _main
