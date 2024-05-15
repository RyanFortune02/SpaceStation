using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGravity : MonoBehaviour
{
    public GameObject player;  //to attach player gameobject and enable gravity
    private int enemyKillCount = 0; //enemies killed
    public TextManager textManager;

    public void EnemyKilled()
    {
        enemyKillCount++;
        if (enemyKillCount == 5)
        {
            //Turn gravity on for player
            Rigidbody playerRigidbody = player.GetComponent<Rigidbody>();
            playerRigidbody.useGravity = true;
            textManager.SetMessageText("Gravity has been enabled look for the console to move on!");  //update text/notify player
        }
    }
}
