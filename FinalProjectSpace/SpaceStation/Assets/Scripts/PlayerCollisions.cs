using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    public HealthManager healthManager;

    //Get spawn position
    private Vector3 spawnPosition;  //Position
    private Quaternion spawnRotation;  //Rotation

    void Start()
    {
        spawnPosition = transform.position;
        spawnRotation = transform.rotation;
    }
    
    void OnCollisionEnter(Collision collision)
    {
        //Increase health when colliding with food items
        if (collision.gameObject.tag == "Health")
        {
            healthManager.IncreaseHealth(25);
            Destroy(collision.gameObject);
        }
        //Decrease health when colliding with floating objects
        else if (collision.gameObject.tag == "FloatingObject") 
        {
            healthManager.DecreaseHealth(25);
            ResetPlayerPosition();
        }
    }
    void ResetPlayerPosition() //Reset to spawn
    {
        transform.position = spawnPosition;
        transform.rotation = spawnRotation;
    }
}
