using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public PlayerGravity playerGravity; //to increase kill count on manager
    public TextManager textManager; //reference text manager script
    public ScoreManager scoreManager;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            //Destroys bullet and Enemy
            Destroy(collision.gameObject); 
            Destroy(gameObject);

            //Increase kill count in PlayerGravity
            playerGravity.EnemyKilled();

            //Update text
            textManager.SetMessageText("You just killed one of the Aliens!");
            //add controller vibration can be improvement (looked into and too many issues for now)
            
            //Add score component later for impovement
            scoreManager.IncrementGameScore(50);

        }
        else  //To keep bullets from boucning around or still existing after collision
        {
            Destroy(gameObject);
        }
    }
}
