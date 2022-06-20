@setlocal enableextensions
@pushd %~dp0
@echo "%~dp0\Randomiser_P\*.*" "..\..\..\*.*" >filelist.txt
.\UnrealPak.exe "Randomiser_P.pak" -create=filelist.txt -compress
del filelist.txt
@popd