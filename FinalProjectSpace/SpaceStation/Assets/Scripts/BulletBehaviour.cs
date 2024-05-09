using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public GameObject player; //to attach player gameobject and enable gravity
    public TextManager textManager; //reference text manager script


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            //Destroys bullet and Enemy
            Destroy(collision.gameObject); 
            Destroy(gameObject);
            //Turn gravity on for player
            Rigidbody playerRigidbody = player.GetComponent<Rigidbody>();
            playerRigidbody.useGravity = true;
            //Update text
            textManager.SetMessageText("You just killed one of the Aliens!");
            //add controller vibration can be improvement
            //Add score component later for impovement
        }
        else  //To keep bullets from boucning around or still existing after collision
        {
            Destroy(gameObject);
        }
    }
}
