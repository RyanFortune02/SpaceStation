//https://gamedev.stackexchange.com/questions/192194/add-random-force-and-direction-to-rigidbodies-every-x-seconds  
// https://stackoverflow.com/questions/27905200/unity3d-random-start-direction-and-forcemode-impulse

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiGravity : MonoBehaviour
{
    /*  When I used animation to rotate the y axis of the object it did not change the direction the object moved.
    void Update()
    {
        Rigidbody floatingobject = GetComponent<Rigidbody>();
        floatingobject.AddForce(Vector3.forward * 1f, ForceMode.VelocityChange);
    }
    */
    private float cooldown = 1.0f; // 
    private float lastRotationTime = 0; //


    
    void Update()
    {
        Rigidbody floatingobject = GetComponent<Rigidbody>(); //get rigid body of floating object
        // Check if the time since the last rotation exceeds the cooldown period
        //time since the start minus the time from last rotation then checking if this is greater than the cool down period
        if (Time.time - lastRotationTime > cooldown)  //https://discussions.unity.com/t/if-collision-happned-2-times-in-2-seconds-play-sound/215898  //Did something similar on StoneStacking in last assingmentS
        {
            
            transform.rotation = Quaternion.Euler(0, Random.Range(0, 360), 0);
            lastRotationTime = Time.time;  //update the last rotation time to the current time

            //floatingobject.AddForce(Vector3.forward * 1f, ForceMode.VelocityChange);
        }
        floatingobject.AddForce(Vector3.forward * 1f, ForceMode.VelocityChange);
    }
}