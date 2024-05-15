using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyCardPickup : OVRGrabbable
{
    public TextManager textManager;

    public override void GrabBegin(OVRGrabber hand, Collider grabPoint)  //decided to use on pickup to execute the logic in "finding the key card"
    {
        base.GrabBegin(hand, grabPoint);
        textManager.SetMessageText("You have found the key card. Touch it against the escape pod to use it!");
    }

    void OnCollisionEnter(Collision collision)
    {
        //Increase health when colliding with food items
        if (collision.gameObject.tag == "EscapePod")
        {
            LoadScene("Ending");
        }
    }

    private void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
