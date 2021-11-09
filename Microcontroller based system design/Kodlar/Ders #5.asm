
_interrupt:
	MOVWF      R15+0
	SWAPF      STATUS+0, 0
	CLRF       STATUS+0
	MOVWF      ___saveSTATUS+0
	MOVF       PCLATH+0, 0
	MOVWF      ___savePCLATH+0
	CLRF       PCLATH+0

;Ders #5.c,1 :: 		void interrupt()
;Ders #5.c,3 :: 		if(intcon.intf == 1)
	BTFSS      INTCON+0, 1
	GOTO       L_interrupt0
;Ders #5.c,5 :: 		intcon.gie = 0;
	BCF        INTCON+0, 7
;Ders #5.c,6 :: 		portb.rb1 = ~portb.rb1;
	MOVLW      2
	XORWF      PORTB+0, 1
;Ders #5.c,7 :: 		intcon.intf = 0;
	BCF        INTCON+0, 1
;Ders #5.c,8 :: 		intcon.inte = 1;
	BSF        INTCON+0, 4
;Ders #5.c,9 :: 		}
L_interrupt0:
;Ders #5.c,10 :: 		}
L_end_interrupt:
L__interrupt4:
	MOVF       ___savePCLATH+0, 0
	MOVWF      PCLATH+0
	SWAPF      ___saveSTATUS+0, 0
	MOVWF      STATUS+0
	SWAPF      R15+0, 1
	SWAPF      R15+0, 0
	RETFIE
; end of _interrupt

_main:

;Ders #5.c,12 :: 		void main()
;Ders #5.c,14 :: 		trisb = 0x01; /*1. portu yani rb0 portunu giriþ olarak ayarladýk. Diðerlerini çýkýþ olarak ayarladýk.*/
	MOVLW      1
	MOVWF      TRISB+0
;Ders #5.c,15 :: 		portb.rb1 = 1; /*Portb.rb1 in deðerini lojik 0 yaptýk.*/
	BSF        PORTB+0, 1
;Ders #5.c,16 :: 		intcon.intf = 0; /*rb0/int kesme bayraðý temizleniyor.*/
	BCF        INTCON+0, 1
;Ders #5.c,17 :: 		intcon.inte = 1; /*rb0/int kesme izin veriliyor.*/
	BSF        INTCON+0, 4
;Ders #5.c,18 :: 		intcon.gie = 1; /*Tüm kesme iþlemlerine izin veriliyor.*/
	BSF        INTCON+0, 7
;Ders #5.c,19 :: 		intcon.peie = 0; /*Çevre arabirimlerden kesmelere izin verilmiyor.*/
	BCF        INTCON+0, 6
;Ders #5.c,20 :: 		option_reg.intedg = 0; /*Yükselen kenarda kesme olacak. (1 ise yükselen kenarda 0 ise düþen kenarda)*/
	BCF        OPTION_REG+0, 6
;Ders #5.c,21 :: 		while(1); /*Ýþemci sonsuz while ile bekletiliyor.*/
L_main1:
	GOTO       L_main1
;Ders #5.c,22 :: 		}
L_end_main:
	GOTO       $+0
; end of _main
