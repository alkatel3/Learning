.386
.model flat, stdcall
option casemap :none
include \masm32\include\masm32rt.inc
.data?
buff db 128 dup(?)
buff_D db 32 dup(?)
buff_notD db 32 dup(?)
buff_E db 32 dup(?)
buff_notE db 32 dup(?)
buff_F db 32 dup(?)
buff_notF db 32 dup(?)
buff_IntegerVariables db 16 dup(?)
.data
String db "08092002",0

A_Byte db 08
not_A_Byte db -08

A_Word dw 08
not_A_Word dw -08
B_Word dw 0809
not_B_Word dw -0809

A_Short dd 08
not_A_Short dd -08
B_Short dd 0809
not_B_Short dd -0809
C_Short dd 08092002
not_C_Short dd -08092002

A_Long dq 08
not_A_Long dq -08
B_Long dq 0809
not_B_Long dq -0809
C_Long dq 08092002
not_C_Long dq -08092002

D_Single dd 0.024
not_D_Single dd -0.024
D_Double dq 0.024
not_D_Double dq -0.024

E_Double dq 2.474
not_E_Double dq -2.474

F_Extended dt 24746.183
not_F_Extended dt -24746.183
F_Double dq 24746.183
not_F_Double dq -24746.183


MsgBoxCaption db "1-23-IP03-Yanyshyn",0
GlobalFormat db "String: %s",10,"%s",10,
                "D=%s",10,"-D=%s",10,
                "E=%s",10,"-E=%s",10,
                "F=%s",10,"-F=%s", 0
IntegerVariableFormat db "A=%d",10,"-A=%d",10,
                         "B=%d",10,"-B=%d",10,
                         "C=%d",10,"-C=%d"



.code
Main:
invoke wsprintf, offset buff_IntegerVariables, offset IntegerVariableFormat, A_Short, not_A_Short,
                                                                             B_Short, not_B_Short,
                                                                             C_Short, not_C_Short
invoke FloatToStr2, D_Double, addr buff_D
invoke FloatToStr2, not_D_Double, addr buff_notD
invoke FloatToStr, E_Double, addr buff_E
invoke FloatToStr, not_E_Double, addr buff_notE
invoke FloatToStr2, F_Double, addr buff_F
invoke FloatToStr2, not_F_Double, addr buff_notF

invoke wsprintf, addr buff, addr GlobalFormat, addr String, addr buff_IntegerVariables, 
                                         addr buff_D, addr buff_notD,
                                         addr buff_E, addr buff_notE, 
                                         addr buff_F, addr buff_notF

invoke MessageBox,0, offset buff,offset MsgBoxCaption, NULL
invoke ExitProcess,0
end Main