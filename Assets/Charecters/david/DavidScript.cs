using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// import for ros tcp connection  
using Unity.Robotics.ROSTCPConnector;
using RosTarget = RosMessageTypes.Unity.Vector3Msg;


public class DavidScript : MonoBehaviour
{
    Vector3 target;
    float speed = 1.1f;
    // Start is called before the first frame update
    void Start()
    {

        //ROSConnection.GetOrCreateInstance().Subscribe<RosTarget>("target", locationChange);
         ROSConnection.GetOrCreateInstance().Subscribe<RosTarget>("David", locationChange);
        
        

    }
    
    void locationChange(RosTarget target)
    {
        SetNewTarget(new Vector3(
            (float)target.pos_x,
             (float)target.pos_y,
            (float)target.pos_z
            )
        
        );
        
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
    }
    void SetNewTarget(Vector3 newTarget)
    {
        Debug.Log("Hello: " );
        target = newTarget;
        transform.LookAt(target);
    }
}
