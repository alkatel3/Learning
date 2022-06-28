.686
.model flat, stdcall
option casemap: none

public DenominatorProc
extern BValues:QWORD, CValues:QWORD, Counter:DWORD, BufPointer:DWORD

.code
DenominatorProc proc 				
	mov edi, Counter
	mov eax, BufPointer
	fld BValues[8*edi] 	      ;B -> st(0)
	fld CValues[8*edi] 	      ;C -> st(0), B ->st(1) 
	fmul               	      ;B*C -> st(0)
	fld1 					;1 -> st(0), B*C -> st(1)
	fadd 					;B*C+1 -> st(0)
	fstp TBYTE PTR [eax] 	
	ret                           
DenominatorProc endp
end
