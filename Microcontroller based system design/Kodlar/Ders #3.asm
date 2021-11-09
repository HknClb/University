
_main:

;Ders #3.c,6 :: 		void main()
;Ders #3.c,8 :: 		trisb = 0; /*b portunu ��k�� olarak ayarlad�k.*/
	CLRF       TRISB+0
;Ders #3.c,9 :: 		portb = 0; /*b portunun t�m pinlerinin de�erlerini logic-0 yapt�k.*/
	CLRF       PORTB+0
;Ders #3.c,10 :: 		trisc = 0x03; /*rc0 ve rc1 pinlerini giri� yap�ld�.*/
	MOVLW      3
	MOVWF      TRISC+0
;Ders #3.c,11 :: 		portc = 0; /*c portunun t�m pinlerinin de�erlerini logic-0 yapt�k*/
	CLRF       PORTC+0
;Ders #3.c,12 :: 		while(1)
L_main0:
;Ders #3.c,14 :: 		if(!arttir) /*rc0 portu 0 m� diye kontrol ettik, butona bas�ld��� anda anahtar kapan�r ve topra�a gider ��nk�, ak�m diren�iz yolu se�er.*/
	BTFSC      PORTC+0, 0
	GOTO       L_main2
;Ders #3.c,16 :: 		display++;
	INCF       _display+0, 1
;Ders #3.c,17 :: 		while(!arttir); /*Butona bas�ld�p �ekildikten sonra buton bir miktar daha bas�l� kal�r burada bas�ld�ktan sonra �ekilmesi bekleniyor.*/
L_main3:
	BTFSC      PORTC+0, 0
	GOTO       L_main4
	GOTO       L_main3
L_main4:
;Ders #3.c,18 :: 		}
L_main2:
;Ders #3.c,19 :: 		if(!azalt)
	BTFSC      PORTC+0, 1
	GOTO       L_main5
;Ders #3.c,21 :: 		display--;
	DECF       _display+0, 1
;Ders #3.c,22 :: 		while(!azalt);
L_main6:
	BTFSC      PORTC+0, 1
	GOTO       L_main7
	GOTO       L_main6
L_main7:
;Ders #3.c,23 :: 		}
L_main5:
;Ders #3.c,24 :: 		if(display < 0)
	MOVLW      128
	XORWF      _display+0, 0
	MOVWF      R0+0
	MOVLW      128
	XORLW      0
	SUBWF      R0+0, 0
	BTFSC      STATUS+0, 0
	GOTO       L_main8
;Ders #3.c,25 :: 		display = 9;
	MOVLW      9
	MOVWF      _display+0
	GOTO       L_main9
L_main8:
;Ders #3.c,26 :: 		else if(display > 9)
	MOVLW      128
	XORLW      9
	MOVWF      R0+0
	MOVLW      128
	XORWF      _display+0, 0
	SUBWF      R0+0, 0
	BTFSC      STATUS+0, 0
	GOTO       L_main10
;Ders #3.c,27 :: 		display = 0;
	CLRF       _display+0
L_main10:
L_main9:
;Ders #3.c,28 :: 		portb = display; /*�nceden hexadecimal kodlar� ile ayarl�yorduk bu yeni ttl 7748 driveri ile direkt onluk tabanda i�lem yapabiliyoruz.*/
	MOVF       _display+0, 0
	MOVWF      PORTB+0
;Ders #3.c,29 :: 		}
	GOTO       L_main0
;Ders #3.c,30 :: 		}
L_end_main:
	GOTO       $+0
; end of _main
