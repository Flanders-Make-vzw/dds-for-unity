@echo off
echo Setting paths for Vortex OpenSplice ..
if "%SPLICE_ORB%"=="" set SPLICE_ORB=DDS_OpenFusion_1_6_1
set OSPL_HOME=<edit: put your OSPL-home here, example C:/...../HDE/x86_64.win64>
set PATH=%OSPL_HOME%\bin;%OSPL_HOME%\lib;%OSPL_HOME%\examples\lib;%PATH%
set OSPL_TMPL_PATH=%OSPL_HOME%\etc\idlpp
if "%OSPL_URI%"=="" set OSPL_URI=<edit: put your xml here, example  ... file://C:/...HDE/x86_64.win64/etc/config/ospl.xml>
echo Starting the application ..
<edit: put your executable here, example .... "C:/Users/.../TurtleROS2.exe">
