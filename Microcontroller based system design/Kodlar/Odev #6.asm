
_interrupt:
	MOVWF      R15+0
	SWAPF      STATUS+0, 0
	CLRF       STATUS+0
	MOVWF      ___saveSTATUS+0
	MOVF       PCLATH+0, 0
	MOVWF      ___savePCLATH+0
	CLRF       PCLATH+0

;Odev #6.c,5 :: 		void interrupt()
;Odev #6.c,7 :: 		if(pir1.tmr1if) /*timer kesmesi olmuþ ise*/
	BTFSS      PIR1+0, 0
	GOTO       L_interrupt0
;Odev #6.c,9 :: 		time++;
	INCF       _time+0, 1
;Odev #6.c,11 :: 		tmr1h = 0x9E;
	MOVLW      158
	MOVWF      TMR1H+0
;Odev #6.c,12 :: 		tmr1l = 0x58;
	MOVLW      88
	MOVWF      TMR1L+0
;Odev #6.c,13 :: 		pir1.tmr1if = 0; /*Kesme bayraðý temizleniyor.*/
	BCF        PIR1+0, 0
;Odev #6.c,14 :: 		}
L_interrupt0:
;Odev #6.c,15 :: 		}
L_end_interrupt:
L__interrupt12:
	MOVF       ___savePCLATH+0, 0
	MOVWF      PCLATH+0
	SWAPF      ___saveSTATUS+0, 0
	MOVWF      STATUS+0
	SWAPF      R15+0, 1
	SWAPF      R15+0, 0
	RETFIE
; end of _interrupt

_main:

;Odev #6.c,17 :: 		void main()
;Odev #6.c,20 :: 		time = trisb = portb = 0;
	CLRF       PORTB+0
	MOVF       PORTB+0, 0
	MOVWF      TRISB+0
	MOVF       TRISB+0, 0
	MOVWF      _time+0
;Odev #6.c,22 :: 		tmr1h = 0x9E;
	MOVLW      158
	MOVWF      TMR1H+0
;Odev #6.c,23 :: 		tmr1l = 0x58;
	MOVLW      88
	MOVWF      TMR1L+0
;Odev #6.c,25 :: 		t1con.t1ckps1 = t1con.t1ckps0 = 1;
	BSF        T1CON+0, 4
	BTFSC      T1CON+0, 4
	GOTO       L__main14
	BCF        T1CON+0, 5
	GOTO       L__main15
L__main14:
	BSF        T1CON+0, 5
L__main15:
;Odev #6.c,27 :: 		t1con.t1oscen = 0;
	BCF        T1CON+0, 3
;Odev #6.c,29 :: 		t1con.tmr1cs = 0;
	BCF        T1CON+0, 1
;Odev #6.c,31 :: 		t1con.tmr1on = 1;
	BSF        T1CON+0, 0
;Odev #6.c,33 :: 		intcon = 0xC0;
	MOVLW      192
	MOVWF      INTCON+0
;Odev #6.c,35 :: 		pie1.tmr1ie = 1;
	BSF        PIE1+0, 0
;Odev #6.c,36 :: 		pir1.tmr1if = 0;
	BCF        PIR1+0, 0
;Odev #6.c,37 :: 		while(1)
L_main1:
;Odev #6.c,39 :: 		switch(time)
	GOTO       L_main3
;Odev #6.c,41 :: 		case 50:
L_main5:
;Odev #6.c,42 :: 		portb = 0x03; /*Saðdan ilk iki led*/
	MOVLW      3
	MOVWF      PORTB+0
;Odev #6.c,43 :: 		break;
	GOTO       L_main4
;Odev #6.c,44 :: 		case 100:
L_main6:
;Odev #6.c,45 :: 		portb = 0x0C; /*Saðdan ikinci iki led*/
	MOVLW      12
	MOVWF      PORTB+0
;Odev #6.c,46 :: 		break;
	GOTO       L_main4
;Odev #6.c,47 :: 		case 150:
L_main7:
;Odev #6.c,48 :: 		portb = 0x30; /*Saðdan üçüncü iki led*/
	MOVLW      48
	MOVWF      PORTB+0
;Odev #6.c,49 :: 		break;
	GOTO       L_main4
;Odev #6.c,50 :: 		case 200:
L_main8:
;Odev #6.c,51 :: 		portb = 0xC0; /*Saðdan dördüncü iki led*/
	MOVLW      192
	MOVWF      PORTB+0
;Odev #6.c,52 :: 		time = 0;
	CLRF       _time+0
;Odev #6.c,53 :: 		break;
	GOTO       L_main4
;Odev #6.c,54 :: 		}
L_main3:
	MOVF       _time+0, 0
	XORLW      50
	BTFSC      STATUS+0, 2
	GOTO       L_main5
	MOVF       _time+0, 0
	XORLW      100
	BTFSC      STATUS+0, 2
	GOTO       L_main6
	MOVF       _time+0, 0
	XORLW      150
	BTFSC      STATUS+0, 2
	GOTO       L_main7
	MOVF       _time+0, 0
	XORLW      200
	BTFSC      STATUS+0, 2
	GOTO       L_main8
L_main4:
;Odev #6.c,55 :: 		}
	GOTO       L_main1
;Odev #6.c,57 :: 		}
L_end_main:
	GOTO       $+0
; end of _main
