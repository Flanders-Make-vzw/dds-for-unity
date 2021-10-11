## TurtleTopics Executable

This is an executable for Windows 10 which contains a publisher (Pose and Compressed Jpeg-stream) and some subscribers to communicate with ROS2. 
This application contains some of the functionality of the famous [TurtleSim](https://docs.ros.org/en/foxy/Tutorials/Turtlesim/Introducing-Turtlesim.html) and also some more. 
Basically this is a TurtleSim version with a 3D-look to showcase some of its capabilities. 

Shown here a picture of the 3D TurtleSim with overlay the old familiar TurtleSim from ROS.
![Turtle Example](https://bitbucket.org/edhage/dds-for-unity/downloads/turtlesim_3d.png)

Because Unity3D is a game-engine, it is quit easy to add a camera. So I could not resist the temptation and added another perspective. In the on-screen GUI you can toggle the camera-perspective. 
This camera moves with the turtle. With the mouse scrollbar you can zoom in and out, and while the mouse left button is pressed you can change your perspective by moving the mouse about (only in the below perspective).

The turtle is a bit distorted because of water diffraction, this is actually a dynamic effect. You see the water move.

![Turtle Perspective](https://bitbucket.org/edhage/dds-for-unity/downloads/turtlesim_3d_perspective.png)


The source-code uses some commercial Unity assets, which prohibits me from providing the source-code of the application. 
Only ROS2-topics are supported right now and not yet services. 



---

## Howto get things started

You will need to have the following installed.

1. Vortex DDS 
2. The application (this directory from the git-repo)
3. ROS2 in your network (or in my case in a Virtual Machine running Ubuntu with ROS2 on the same computer)

### Changing the bat-file
As a prerequisite Vortex DDS must be installed. 

Than you have to alter the bat-file **start_with_DDS.bat** to edit the correct locations of the Vortex DDS installation. In the file itself it is shown where input is required. This must be done to start Vortex DDS with the application.
If you would only run the TurtleROS2.exe than DDS would not be enabled and communication with ROS2 is not facilitated.

### Configuring the application

The config.json allows configuration of the topic-names and the compression of the jpeg-stream (of a turtle head-cam). The config.json needs to be present otherwise the application will fail.

The configuration is quit straightforword and the content is shown here:

```
{ "VelocitySubscriber" : "rt/turtle2/cmd_vel",
  "PosePublisher" : "rt/turtle2/pose",
  "EatSubscriber" : "rt/turtle2/eat",
  "DieSubscriber" : "rt/turtle2/die",
  "AttackSubscriber" : "rt/turtle2/attack",
  "HeadCamPublisher" : {
	  "Topic": "rt/turtle2/headcam", 
	  "jpegcomp" : 45 }
}
```

Bare in mind that every topic should start with `rt/` to be able to be visible in ROS2. This is also true for native ROS2-messages, but the `rt/` is simply not shown in ROS2.

---

## Running ROS2 
If you have set up Vortex DDS correctly than you should be able to see the topics that are used in the application. See the json-file above to see the the names of the topic.
The user is expected to have some knowledge from ROS and is capable of displaying and publishing topics via the commandline. Here some examples will be given.

### cmd_vel

You can give commands in ROS2 (any version should be fine, tested it with **galactic**) to move or rotate the turtle. For this command the type geometry_msgs/msg/Twist is used.
For linear motion only the x and y coordinate are used, and for rotation the angular z coordinate. This is a speed-setpoint, which it will last at most for 1 second. 
This means that if within 1 second no other cmd_vel is received than the turtle will stop. This is the same implementation as the ROS2-turtlesim.

You can give the commands like this in a terminal (it will bend to the left and describe a circle): 

```ros2 topic pub /turtle2/cmd_vel geometry_msgs/msg/Twist {"linear: { x: 1, y: 0, z: 0}, angular:  { x: 0, y: 0, z: 1 } "} ```

### pose
The pose is published with a rate of 50 Hz and you can subscribe to it (and show it in rqt_gui if you desire), the topic has type geometry_msgs/msg/Pose .

### eat, die and attack
These are topics that are boolean and publishing to it will trigger the animation that describes the topic. Be careful with the topic "die" because it prohibits it from doing something else afterward (which is very similar to a real situation). 
Actually the functions will be triggered if the input is true or false.

```
ros2 topic pub /turtle2/eat std_msgs/msg/Bool {"data: true"} --once
ros2 topic pub /turtle2/die std_msgs/msg/Bool {"data: true"} --once
ros2 topic pub /turtle2/attack std_msgs/msg/Bool {"data: true"} --once
```

### headcam
I put a camera on top of the turtle ("wild-cam") and it publishes a 5Hz compressed jpeg-image-stream. It publishes on the topic given in the config.json file added with "/image_raw/compressed".

The headcam is shown here:

![Headcam streaming](https://bitbucket.org/edhage/dds-for-unity/downloads/headcam_on_turtle_small.png)

This is a feature which was not in the original TurtleSim. 




