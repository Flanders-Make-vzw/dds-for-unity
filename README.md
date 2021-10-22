## DDS for Unity
This package adds DDS capability to Unity. This has been written to couple digital twins and simulators, made in Unity, with ROS2. 

This has succesfully been used with Unity as simulator to test a controllers deployed in ROS2 (closing the control-loop with Unity application as the simulated hardware). The same has been done with a controller deployed on a Raspberry Pi with native DDS (not ROS) has been used with a Unity simulator. 
Furthermore mobile platforms have been simulated in Unity being driven from ROS. Cameras setup in Unity stream compressed jpeg-video to ROS2. 

An executable Unity-program (for Windows 10) is added to this repository, called TurtleTopics, which can be used as an example to communicate with ROS2. This includes streaming images from a "wild-cam" mounted to the head of the turtle (No turtles have been hurt in the making of this software).
Th executable is found in the executable-directory, it does not require installation of Unity. 

The source-code is found in the src/Assets/DDS-directory. The DDS-directory could be directly copied in the Assets-folder in your Unity3D-project, or more conveniently, you can load the Unity-package in the unity-package directory.
The package consists of wrappers around the common ROS-topics and some functions to make the use in Unity3D more convenient. This package is made for Unity 2019, and should also work for version 2017 or 2018. I have tried it in version 2020 and it does not work. The dll-s give me trouble, so I have to look into this.

## Flanders Make
This software has been developed by Edward Hage. Some parts are developed in assignment for [Flanders Make](https://www.flandersmake.be/). Flanders Make offer active support to companies in the manufacturing industry to develop and optimise products and production processes. This is based on high-tech research.
Flanders Make is an initiative supported by the Flemish Government, the Limburg Fund and the ERDF.

## Installation using the Unity-package

This you have to do load the DDS functionality.

1. Generate a new Unity project in Unity Hub. Choose a 2019 version, for the exercise 2019.4.29f is used.
2. When the  project is opened go to Assets -> Import Package -> Custom Package .. 
3. Select the package DDSforUnity.2019.unitypackage and click **Open**
4. A dialog window with all the contents of the package pops up, select all files (if not already) and click **Import**.

![Import Unity package](https://bitbucket.org/edhage/dds-for-unity/downloads/window_import_DDS_for_unity.png)!

5. The package is loaded and as a result the folder DDS is created under the Assets folder.
6. In the menu bar als the option DDS appears. Click DDS --> Vortex and a window will appear called DefineDDS.

![Set Vortex DDS settings in Unity](https://bitbucket.org/edhage/dds-for-unity/downloads/define_dds_window.png)

7. Here you must fill in the OSPL Home Directory and the OSPL Config file. This information will be used to build a bat-file that automatically starts the built app with DDS-support.
8. Some dll-s have been loaded which only take effect if the Editor is re-started. First make this bat-file.

You probably do not only want to be able to develop programs with DDS, you also want to test them in the Editor. To do this fist make a bat-file and store it in the project directory root.

```
@echo off
echo Setting paths for Vortex OpenSplice ..
if "%SPLICE_ORB%"=="" set SPLICE_ORB=DDS_OpenFusion_1_6_1
set OSPL_HOME=D:\HDE\x86_64.win64
set PATH=%OSPL_HOME%\bin;%OSPL_HOME%\lib;%OSPL_HOME%\examples\lib;%PATH%
set OSPL_TMPL_PATH=%OSPL_HOME%\etc\idlpp
if "%OSPL_URI%"=="" set OSPL_URI=file://%OSPL_HOME%\etc\config\ospl_vm.xml
echo Starting Unity ..
"C:\Program Files\Unity\Hub\Editor\2019.4.29f1\Editor\Unity.exe" -projectPath "D:\Unity_projects\TurtleROS2"
```

This is an example, what you typically want to change is the OSPL_HOME directory and on the last line change the Unity.exe to the location where you have stored Unity.exe. The projectPath specified should be your project root.

8. Restart the Editor using the bat-file.

(So a similar bat-file will be generated automatically if you compile the code. For now this file, to start the Editor with DDS-support, needs to be created by hand).


---

## Prerequisites

### Install Vortex DDS

First is to install Vortex DDS [Vortex OpenSplice Community Edition](https://github.com/ADLINK-IST/opensplice). Vortex OpenSplice is a full implementation of the OMG DDS Standard licensed under Apache 2. 

### Firewall ###
If you have a Windows computer in your network than by default the UPD ports 7400 to 7500 are blocked. These are the ports used by DDS so you want to open them. In Windows 10 open "Windows Defender Firewall with Advanced Security" and add an inbound and an outbound rule to open those ports.

---
## Call for Support
Flanders Make is interested to know if you find this software usefull. Please contact Flanders Make at info@flandersmake.be with your usecase. 

