.386
.model flat, stdcall
option casemap :none
include \masm32\include\masm32rt.inc

.data?
Buff db 256 dup(?)
GlobalBuff db 512 dup(?)

.data
;arrays of variables
A_values dd 2,12, -18,-70,-112
C_values dd 6,10, 6,-60,-30
D_values dd 3,-2, 3,12,-15
MsgBoxCaption db "1-23-IP-03-Yanyshyn", 0
MyVariant db "Variant 3: (c/d+3*a/2)/(c-a+1).", 10,10, 0
PreviewAndResult db "(%d / %d + 3 * %d / 2)/(%d - %d + 1) = %d/%d", 10, 
"Result: %d", 10, "EndResult: %d", 10, 10, 0
Error db "Change variables", 10, 10, 0
Denominator dd 0
Numerator dd 0
Results dd 5 dup(?)
EndResult dd 5 dup(?)

.code
Main:
mov edi, 0;   counter
invoke wsprintf, offset GlobalBuff, offset MyVariant

.while edi < 5
mov ecx, C_values[4 * edi]
mov ebx, A_values[4 * edi]
sub ecx, ebx            ;c-a -> ecx    
inc ecx                 ;c-a+1 -> ecx
mov Denominator, ecx
mov eax, C_values[4 * edi]
mov ebx, D_values[4 * edi]

.if ebx!=0 && Denominator!=0
cdq
idiv ebx         	; c/d -> eax
mov Numerator, eax
mov ecx, A_values[4 * edi]
mov eax, 3
cdq
imul eax, ecx		; 3*a -> eax
mov ebx, 2
cdq
idiv ebx               ;3*a/2 -> eax
add Numerator, eax
mov eax, Numerator
mov ecx, Denominator
cdq
idiv ecx 		      ; result -> eax
mov Results[4*edi], eax
test eax, 1
jnz oddResult 
jz evenResult

evenResult:
mov ebx, 2
cdq
idiv ebx
mov EndResult[4*edi], eax
jmp fillBuf

oddResult:
imul eax, 5
mov EndResult[4*edi], eax
jmp fillBuf

fillBuf:   
invoke wsprintf, offset Buff, offset PreviewAndResult, 
                 C_values[4 * edi], D_values[4 * edi], 
		     A_values[4 * edi], C_values[4 * edi],
                 A_values[4 * edi], Numerator, Denominator, 
		     Results[4 * edi], EndResult[4 * edi]
                   
.else
invoke wsprintf, offset Buff, offset Error

.endif
invoke szCatStr, offset GlobalBuff, offset Buff
inc edi

.endw
invoke MessageBox, 0, addr GlobalBuff, addr MsgBoxCaption, 0
end Main