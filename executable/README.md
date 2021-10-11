## TurtleTopics Executable

This is an executable for Windows 10 which contains a publisher (Pose and Compressed Jpeg-stream) and some subscribers to communicate with ROS2. 
This application contains some of the functionality of the famous [TurtleSim](https://docs.ros.org/en/foxy/Tutorials/Turtlesim/Introducing-Turtlesim.html) and also some more. 
Basically this is a TurtleSim version with a 3D-look to showcase some of its capabilities. The source-code uses some commercial Unity assets, which prohibits me from providing the source-code of the application. 
Only ROS2-topics are supported right now and not yet services. 



---

## Howto get things started

You will need to have the following installed.

1. Vortex DDS 
2. The application (this directory from the git-repo)
3. ROS2 in your network (or in my case in a Virtual Machine running Ubuntu with ROS2 on the same computer)


---

## Running ROS2 

Like the ROS2 turtlesim you can give commands in ROS2 (any version should be fine, tested it with **galactic**).


```ros2 topic pub /turtle2/cmd_vel geometry_msgs/msg/Twist {"linear: { x: 1, y: 0, z: 0}, angular:  { x: 0, y: 0, z: 1 } "} ```

