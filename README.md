# Goal-Object-Asociation
Introduction:

Welcome to the project built on Unity that focuses fecilitating testing robot navigation algorithms in a simulated environment. This project offers a comprehensive solution for evaluating and fine-tuning navigation algorithms without the need to deal with complex image recognition or collision detection that are associated with tesign a robot navigation in a real environment. With the following key features, it provides a robust platform for experimenting with and validating navigation algorithms:

1. Simulation of Robot Navigation:
The project allows users to test robot navigation algorithms by providing navigation commands to Unity from ROS. Unity, in turn, simulates the movement and behavior of the robot based on these commands. 

2. Realistic Physics Simulation:
To enhance the realism of the experiment, the project incorporates physics components. By leveraging Unity's physics engine, the simulation mimics real-world interactions and provides an immersive experience. This feature enables users to observe and analyze how the robot interacts with the environment and objects within it.

3. Integration of ROS (Robot Operating System):
This project has the integration of Unity with the Robot Operating System (ROS) to access real-time location data of all characters and static objects within the environment. By connecting Unity with ROS, we can obtain accurate and up-to-date information, enabling precise analysis and decision-making based on the robot's surroundings.

4. Robot Movement Control via ROS:
Through the ROS integration, users can control the movement of the robot by sending destination locations. This feature enables the evaluation of navigation algorithms in different scenarios and conditions.

5. Character Movement Control via ROS:
This project allows movement control of all characters anf the Robot within the simulation environment. By providing location information through ROS, users can dynamically move characters to specific destinations. 

6. Simplified Navigation Algorithm Testing:
This project significantly simplifies the process of testing navigation algorithms. By abstracting away image recognition and collision detection complexities, users can solely focus on assessing the efficiency and efficacy of their navigation strategies. The simulation environment provides a controlled and customizable setup for comprehensive algorithm validation.


# Integrating ROS with Unity
To integrate ROS with Unity and enable real-time communication and interaction, please follow the steps below:

Building ROS for Unity
Copy the PythonScripts/Unity directory to your Catkin workspace (catkin_ws).
Run the following command in the terminal to build the workspace:
```bash
    Copy code
    cd ~/catkin_ws/
    catkin_make 
```
Running ROS Client to View ROS Messages
To visualize ROS messages and monitor the communication, perform the following steps:

Open a terminal and navigate to your catkin_ws directory.
Run the command source devel/setup.sh to set up the ROS environment variables.
In another terminal, execute the following commands to set the ROS IP and start the ROS core:
bash
Copy code
rosparam set ROS_IP 192.168.50.91
roscore
Note: Modify the ROS_IP value according to your specific network configuration.

Adding Maximo Character
To add a Maximo character to your Unity project, follow these steps:

1. Download the Maximo character model and animation from the following link: https://www.mixamo.com/#/
2. Import the Maximo character model into Unity:
    1. In Unity's Project window, navigate to the desired import location for the Maximo character.
    2. Copy the Maximo character model files  into the chosen folder.
    3. Unity will automatically import the model and its associated assets.

3. Click on the character asset and configure the rig and materials:

4. Click on the charecter (asset). rig->AnimationTpe = Humanoid. Materials-> extract to material folder.
5. click on the animation type. Rig->source= chrecter name. Animations-> select loop time. 
6. Create an Animator Controller asset in Unity and set it as the character's controller.
7. Configure the Animator Controller by adding animation clips and setting up transitions between them. 


# Calling ROS Service from Unity
To call a ROS service from Unity, use the following command:

``` bash
Copy code
rosservice call /obj_pose_srv Cube 
```
Please ensure the following:

The class name and file name in Unity match the corresponding ROS service.
To add a custom message to ROS, create a workspace in Catkin, build the workspace, and then import the message into Unity.
For detailed guidance on setting up ROS with Unity, you can refer to the following video tutorial: ttps://www.youtube.com/watch?v=pdMxLxolQuo

