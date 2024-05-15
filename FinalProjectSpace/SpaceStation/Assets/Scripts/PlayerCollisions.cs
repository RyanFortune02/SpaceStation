using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    public HealthManager healthManager; //references to other scripts
    public TextManager textManager;
    public GunShooting gunShooting;

    //Get spawn position
    private Vector3 spawnPosition;  //Position
    private Quaternion spawnRotation;  //Rotation

    private int foodpickup;

    void Start()  //starting spawn position
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
            Destroy(collision.gameObject);  //https://thiscodedoesthis.com/how-to-destroy-a-gameobject-on-collision-in-unity/
            foodpickup += 1;
            if (foodpickup == 3)  //After picking up all of the food items updates display
            {
                textManager.SetMessageText("You have picked up all the food now");
            }
        }
        //Decrease health when colliding with floating objects
        else if (collision.gameObject.tag == "FloatingObject") 
        {
            healthManager.DecreaseHealth(25);
            ResetPlayerPosition();
        }
        else if (collision.gameObject.tag == "Enemy")
        {
            ResetPlayerPosition();
            healthManager.DecreaseHealth(25);
            textManager.SetMessageText("That hurt! Don't get hit by the aliens.");

            gunShooting.ResetGunPosition();//Reset the gun position
        }
        else if (collision.gameObject.tag == "FallPlane")  //if player falls off map it resets them to spawn  (too many of imported  assets allow to walk through windows)
        {
            ResetPlayerPosition();
            textManager.SetMessageText("Watch your step!");

        }
    }
    void ResetPlayerPosition() //Reset to spawn
    {
        transform.position = spawnPosition;
        transform.rotation = spawnRotation;
    }
}
