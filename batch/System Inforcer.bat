@Echo off
mode 800
:main_menu
cls 
title System Inforcer
echo System Inforcer 1.0.0 
echo 1- Net Commands
echo 2- Windows Network Diagnostic Commands
echo 0- Exit System Inforcer
echo: 
set/p choice1="Enter Choice:"

if %choice1% LSS 0 (

cls 
  color 4
  echo There is no such option!
  ping localhost -n 3 >nul  
  cls 
  color 7 
  goto main_menu

)

if %choice1% GEQ 3 (

cls 
  color 4
  echo There is no such option!
  ping localhost -n 3 >nul  
  cls 
  color 7 
  goto main_menu
 
)

if %choice1%==2 goto WND_page
if %choice1%==1 goto net_page
if %choice1%==0 exit 

:net_page
cls 
echo 1- Accounts
echo 2- Users
echo 3- Computer
echo 4- Config
echo 5- Continue
echo 6- Local Group
echo 7- Pause 
echo 8- Share
echo 9- Start
echo 10- Statistics
echo 11- Use 
echo 12- View 
echo 0- Exit Net Commands
echo:
set/p choice2="Enter Choice:" 

if %choice2% LSS 0 (

cls 
  color 4
  echo There is no such option!
  ping localhost -n 3 >nul  
  cls 
  color 7 
  goto net_page

)

if %choice2% GEQ 14 (

cls 
  color 4
  echo There is no such option!
  ping localhost -n 3 >nul  
  cls 
  color 7 
  goto net_page

)

if %choice2%==0 goto main_menu
if %choice2%==12 goto View
if %choice2%==11 goto Use 
if %choice2%==10 goto Statistics
if %choice2%==9 goto Start1
if %choice2%==8 goto Share
if %choice2%==7 goto Pause1
if %choice2%==6 goto Local_Group
if %choice2%==5 goto Continue
if %choice2%==4 goto Config
if %choice2%==3 goto Computer
if %choice2%==2 goto Users
if %choice2%==1 goto Accounts

:Accounts
cls
net accounts
echo Press any key to back main menu...
pause>nul
cls
goto net_page

:Users
cls
net user
echo Press any key to back main menu...
pause>nul
cls
goto net_page

:Config
cls 
net config 
echo Press any key to back main menu...
pause>nul
cls
goto net_page

:Computer 
cls 
net computer 
echo Press any key to back main menu...
pause>nul
cls
goto net_page

:Continue
cls 
net continue  
echo Press any key to back main menu...
pause>nul
cls
goto net_page

:Local_Group
cls 
net localgroup 
echo Press any key to back main menu...
pause>nul
cls
goto net_page

:Pause1 
cls 
net pause 
echo Press any key to back main menu...
pause>nul
cls
goto net_page

:Share 
cls 
net share 
echo Press any key to back main menu...
pause>nul
cls
goto net_page

:Start1 
cls 
net start 
echo Press any key to back main menu...
pause>nul
cls
goto net_page

:Statistics 
cls 
net statistics
echo Press any key to back main menu...
pause>nul
cls
goto net_page 

:Use 
cls 
net use 
echo Press any key to back main menu...
pause>nul
cls
goto net_page

:View 
cls 
net view 
echo Press any key to back main menu...
pause>nul
cls
goto net_page

:WND_page
cls
color 7 
echo 1- Windows IP Configuration
echo 2- Net Stat
echo 3- Get Mac 
echo 0- Exit Windows Network Diagnostic Commands
echo: 
set/p choice3="Enter Choice:" 

if %choice3% LSS 0 (

cls 
  color 4
  echo There is no such option!
  ping localhost -n 3 >nul  
  cls 
  color 7 
  goto WND_page

)


if %choice3% GEQ 4 (

cls 
  color 4
  echo There is no such option!
  ping localhost -n 3 >nul  
  cls 
  color 7 
  goto WND_page

)

if %choice3%==3 goto Getmac 
if %choice3%==2 goto Netstat
if %choice3%==1 goto Ipconfig 
if %choice3%==0 goto main_menu

:Ipconfig
cls 
ipconfig
echo:
echo Press any key to back main menu...
pause>nul
cls
goto WND_page

:Netstat
cls 
netstat 
echo: 
echo Press any key to back main menu...
pause>nul
cls
goto WND_page

:Getmac 
cls 
getmac 
echo: 
echo Press any key to back main menu...
pause>nul
cls
goto WND_page