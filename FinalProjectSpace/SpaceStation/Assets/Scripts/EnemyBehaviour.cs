using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    //https://www.youtube.com/watch?v=EA54-vfLkUI&t=4s  Has way to look at player can use with move towards command as well to follow
    //https://www.youtube.com/watch?v=9eTZqxxgGz8  Another useful video for future reference - has move towards syntax

    public Transform player; //player's position

    public float followSpeed = 2.0f;  //May make faster in future, appears slow

    
    void Update()
    {
        transform.LookAt(player); //Makes alien look at player & line under makes it move toward
        transform.position = Vector3.MoveTowards(transform.position, player.position, followSpeed * Time.deltaTime);
    }
}
