.686
.model flat, stdcall
option casemap: none

include \masm32\include\masm32rt.inc

public BValues, CValues, Counter, BufPointer       
extern DenominatorProc:PROTO                       

.data?
GlobalBuf		dq  1024    DUP(?)
BufFormat         dq  1024    DUP(?)
BufForResult      dq  1024	DUP(?)
SqrtBuf		dt  ?        
SubBuf	      dt  ?        
DenominatorBuf	dt  ?        
BufPointer	      dd  ?       
Counter 	      dd  ?        

.data
AValues dq 0.5, 1.5, 3.5, -4.3, 42.1
BValues dq 2.3, 3.3, 5.1, 1.5, 5.5
CValues dq 5.6, -1.1, 2.2, -13.2, 1.5
DValues dq -11.1, 2.3, 12.22, -14.65, 1.3

ResultFormat db "Result: %s", 13, 13, 0
MyVariant db "Variant 21: ( sqrt(53/a) + d - 4*b ) / ( 1+b*c)", 13, 13, 0
MsgBoxCaption db "7-23-IP-03-Yanyshyn", 0
Error db "Error! Change variables!", 0
ResultValue dq 0,0      
Four dq 4.0
FiftyThree dq 53.0
      
.code

SqrtProc proc
push ebp		                        ;пролог
mov ebp, esp			
mov esi, [ebp + 8]				;edi ->esi
mov ecx, [ebp + 16]				;53 -> ecx
mov ebx, [ebp + 20]				;A ->ebx		
fld qword ptr [ecx]				;53 -> st(0)	
fdiv qword ptr [ebx + esi * 8]            ;53/A -> st(0)
fsqrt							;sqrt(42/b) -> st(0)
mov ebx, [ebp + 12]				;SqrtBuf -> ebx
fstp TBYTE ptr [ebx]                      ;sqrt(42/b) -> SqrtBuf
pop ebp		                        ;≈п≥лог
ret 16		                       
SqrtProc endp

SubProc proc	
finit
fld qword ptr [ecx + edi*8]   ;D -> st(0)
fld qword ptr [eax + edi*8]	;B -> st(0), D -> st(1)
fld qword ptr [edx]		;4 -> st(0), B -> st(1), D -> st(2)
fmul 					;4*B -> st(0), D -> st(1)
fsub
fstp TBYTE ptr [ebx]                
ret
SubProc endp

start:
mov edi, 0 
invoke szCatStr, offset GlobalBuf, offset MyVariant

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
fld AValues[8*edi] 	;A -> st(0) 
ftst
fstsw ax
sahf
jb errorBlock

finit
push offset AValues
push offset FiftyThree
push offset SqrtBuf
push edi				
call SqrtProc 			
	
mov ecx, offset DValues
mov eax, offset BValues	
mov ebx, offset SubBuf
mov edx, offset Four
call SubProc 		

push offset DenominatorBuf
pop BufPointer
mov Counter, edi
call DenominatorProc
			
finit
fld SqrtBuf                 ;SqrtBuf -> st(0)
fld SubBuf                  ;SubBuf -> st(0), SqrtBuf -> st(1)
fadd                        ;SubBuf+SqrtBuf -> st(0)
fld DenominatorBuf          ;DenominatorBuf -> st(0), SubBuf+SqrtBuf -> st(1)
fdiv                        ;(SubBuf+SqrtBuf)/DenominatorBuf -> st(0)
fstp ResultValue		    ;st(0) -> ResultValue
invoke FloatToStr2, ResultValue, offset BufForResult
invoke wsprintf, offset BufFormat , offset ResultFormat, offset BufForResult
jmp final

errorBlock:
invoke wsprintf, offset BufFormat , offset ResultFormat, offset Error


final:
invoke szCatStr, addr GlobalBuf, addr BufFormat 
inc edi
			
.if edi<5
jmp Calculate

.endif
invoke MessageBox, 0, addr GlobalBuf, addr MsgBoxCaption, 0
invoke ExitProcess, 0
end start