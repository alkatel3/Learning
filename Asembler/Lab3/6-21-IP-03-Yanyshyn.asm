.386
.model flat, stdcall
option casemap :none

include \masm32\include\masm32rt.inc

.data?
BufForResult dq	1024 DUP(?)
BufFormat dq	1024 DUP(?)
GlobalBuf dq 1024 DUP(?)
	
.data
AValues dq 0.5, 1.5, 3.5, -4.3, 42.1
BValues dq 2.3, 3.3, 5.1, 1.5, 5.5
CValues dq 5.6, -1.1, 2.2, -13.2, 1.5
DValues dq -11.1, 2.3, 12.22, -14.65, 1.3

ResultFormat db "Result: %s", 13, 13, 0

MyVariant db "Variant 21: ( sqrt(53/a) + d - 4*b ) / ( 1+b*c)", 13, 13, 0

MsgBoxCaption db "1-23-IP-03-Yanyshyn", 0
Error db "Error! Change variables!", 0
ResultValue dq 0,0
Denominator dq 0.0
Four dq 4.0
FiftyThree dq 53.0

.code

start:
mov edi, 0
invoke wsprintf, offset GlobalBuf, offset MyVariant

Calculate:
finit
fld BValues[8*edi] 	;B -> st(0) 
fld CValues[8*edi] 	;C -> st(0), B -> st(1)  
fmul                    ;B * C -> st(0)
fld1 			      ;1 -> st(0), B * C -> st(1)
fadd 				;1+B*C -> st(0)
ftst
fstsw ax
sahf
je errorBlock
fstp Denominator
fld AValues[8*edi]   ;A -> st(0)
ftst		
fstsw ax
sahf
jb errorBlock

finit
fld FiftyThree		;53 -> st(0)
fld AValues[8*edi]	;A -> st(0), 53 -> st(1) 
fdiv                    ;53/A -> st(0)
fsqrt 	            ;sqrt(53/A) -> st(0),
fld DValues[8*edi] 	;D -> st(0), sqrt(53/A) -> st(1)
fadd                    ;sqrt(53/A) + D -> st(0) 
fld Four 			;4 -> st(0), sqrt(53/A) + D -> st(1) 
fld BValues[8*edi] 	;B -> st(0), 4 -> st(1), sqrt(53/A) + D -> st(2) 
fmul                    ;4*B -> st(0), sqrt(53/A) + D -> st(1) 
;fxch st(1)              ;sqrt(53/A) + D -> st(0), 4*B -> st(1)
fsub                    ;sqrt(53/A)+D-4*B -> st(0)	
fld Denominator			
fdiv 				;(sqrt(53/A)+D-4*B)/(1+B*C) -> st(0)
fstp ResultValue
invoke FloatToStr2, ResultValue, offset BufForResult
invoke wsprintf, offset BufFormat, offset ResultFormat, offset BufForResult
jmp final
		
errorBlock:
invoke wsprintf, offset BufFormat, offset ResultFormat, offset Error

final:
invoke szCatStr, offset GlobalBuf, offset BufFormat
inc edi

.if edi<5
jmp Calculate

.endif
invoke MessageBox, 0, offset GlobalBuf, offset MsgBoxCaption, 0
end start