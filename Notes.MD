

# To DO
Environment 1
1. create the layout and add objects

2. generateHeatMap():
    2.1 Create a dummy file to generate a heap map -- DONE
    2.2 Integrate it with ros output
    2.3 Get object location
     

3. getObjects()
    3.1 Send the location/object details
        3.1.1 create a ros message --Done
    3.2 get objects


Environment 2:
1. findObjects()
   1.1 send objects()
   1.2 get object location: ROS service

2. getEnvironmentSnapshot()
3. getDestination()


publish ROS messages:
getHumanLocation()
getRobotLocation()


# Runnig Ros client to see ros messages
```bash
    cd ~/catkin_ws/
    source devel/setup.sh 
    #in another terminal
    rosparam set ROS_IP 192.168.50.91
    roscore
```


adding maximo charecter
1. Download Maximo charecter and animation from here: https://www.mixamo.com/#/
2. Import the Maximo character model:
    1. In Unity's Project window, navigate to the folder where you want to import the Maximo character.
    2. Copy the Maximo character model files (FBX, OBJ, textures, etc.) into the folder.
    3. Unity will automatically import the model and its associated assets.
    4. Set up the character's materials and textures:

3. copy the animation and charecter model to Assets
4. Click on the charecter (asset). rig->AnimationTpe = Humanoid. Materials-> extract to material folder.
5. click on the animation type. Rig->source= chrecter name. Animations-> select loop time. 
6. Create an Animator Controller asset in Unity and set it as the character's controller.
7. Configure the Animator Controller by adding animation clips and setting up transitions between them. 




To call the ros service : rosservice call /obj_pose_srv Cube


1. the class name and file name should match
2. To add any custom message to ROS, create a WS in carkin and build the srokspace then import the message in unity


ROS UNity setup : https://www.youtube.com/watch?v=pdMxLxolQuo


cd Py   
