using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            //Destroys bullet and Enemy
            Destroy(collision.gameObject); 
            Destroy(gameObject);
            //Add UI update
            //Add score component later
            //Turn gravity on for player and set objects
        }
        else if (collision.gameObject.tag == "Map")  //To keep bullets from boucning around or still existing after collision
        {
            Destroy(gameObject);
        }
    }
}
