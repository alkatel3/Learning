@echo off

\masm32\bin\ml /c /coff "7-21-IP-03-Yanyshyn.asm" "7-21-IP-03-Yanyshyn2.asm"
\masm32\bin\link /subsystem:windows "7-21-IP-03-Yanyshyn.obj" "7-21-IP-03-Yanyshyn2.obj"
PAUSE