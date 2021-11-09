
_interrupt:
	MOVWF      R15+0
	SWAPF      STATUS+0, 0
	CLRF       STATUS+0
	MOVWF      ___saveSTATUS+0
	MOVF       PCLATH+0, 0
	MOVWF      ___savePCLATH+0
	CLRF       PCLATH+0

;Ders #7.c,27 :: 		void interrupt()
;Ders #7.c,29 :: 		if(tmr0if_bit == 1)
	BTFSS      TMR0IF_bit+0, 2
	GOTO       L_interrupt0
;Ders #7.c,31 :: 		counter++;;
	INCF       _counter+0, 1
;Ders #7.c,32 :: 		tmr0 = 158;
	MOVLW      158
	MOVWF      TMR0+0
;Ders #7.c,33 :: 		tmr0if_bit = 0;
	BCF        TMR0IF_bit+0, 2
;Ders #7.c,34 :: 		}
L_interrupt0:
;Ders #7.c,35 :: 		}
L_end_interrupt:
L__interrupt5:
	MOVF       ___savePCLATH+0, 0
	MOVWF      PCLATH+0
	SWAPF      ___saveSTATUS+0, 0
	MOVWF      STATUS+0
	SWAPF      R15+0, 1
	SWAPF      R15+0, 0
	RETFIE
; end of _interrupt

_main:

;Ders #7.c,37 :: 		void main()
;Ders #7.c,39 :: 		trisb = portb = counter = 0;
	CLRF       _counter+0
	CLRF       PORTB+0
	MOVF       PORTB+0, 0
	MOVWF      TRISB+0
;Ders #7.c,40 :: 		portb.rb0 = 0;
	BCF        PORTB+0, 0
;Ders #7.c,41 :: 		option_reg = 0xC7;
	MOVLW      199
	MOVWF      OPTION_REG+0
;Ders #7.c,42 :: 		intcon = 0xC0;
	MOVLW      192
	MOVWF      INTCON+0
;Ders #7.c,43 :: 		tmr0ie_bit = 1;
	BSF        TMR0IE_bit+0, 5
;Ders #7.c,44 :: 		tmr0if_bit = 0; /*Kesme bayraðýný her ihtimale karþý temizledik.*/
	BCF        TMR0IF_bit+0, 2
;Ders #7.c,45 :: 		tmr0 = 158;
	MOVLW      158
	MOVWF      TMR0+0
;Ders #7.c,46 :: 		while(1)
L_main1:
;Ders #7.c,49 :: 		if(counter >= 100)
	MOVLW      128
	XORWF      _counter+0, 0
	MOVWF      R0+0
	MOVLW      128
	XORLW      100
	SUBWF      R0+0, 0
	BTFSS      STATUS+0, 0
	GOTO       L_main3
;Ders #7.c,51 :: 		counter = 0;
	CLRF       _counter+0
;Ders #7.c,52 :: 		portb.rb0 = ~portb.rb0;
	MOVLW      1
	XORWF      PORTB+0, 1
;Ders #7.c,53 :: 		}
L_main3:
;Ders #7.c,54 :: 		}
	GOTO       L_main1
;Ders #7.c,55 :: 		}
L_end_main:
	GOTO       $+0
; end of _main
