using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;  // Include the SceneManager namespace

public class TextManager : MonoBehaviour
{
    public Text MessageText;

    public void SetMessageText(string message)
    {
        MessageText.text = message;
    }

    void Start()
    {
        //Used for getting current active scene to display a start up message in the UI
        //https://gamedev.stackexchange.com/questions/153707/how-to-get-current-scene-name 
        //Unity Docs for future reference: https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.GetActiveScene.html
        var currentScene = SceneManager.GetActiveScene();
        var currentSceneName = currentScene.name;
        //Sets text for start of each scene
        if (currentSceneName == "CryoScene")
        {
            SetMessageText("Welcome! You have just woken from Cryosleep! Look to your left for instructions. Click the first Button!");
        }
        else if (currentSceneName == "SpaceHallway")
        {
            SetMessageText("You seem hungry as you have not eaten in over 100 years. Find food resources for health. Escape floating objects as they look like they are dangerous!");
        }
        else if (currentSceneName == "SpaceShoot")
        {
            SetMessageText("The gravity generators have been turned off by the aliens. Shoot the Aliens to turn the gravity back on.");
        }
        else if (currentSceneName == "FailScene")
        {
            SetMessageText("You have failed the game. Click the button if you would like to restart!");
        }
        else if (currentSceneName == "EndScene")
        {
            SetMessageText("You have escape the invaders and made it to the main area of the Space Station. Look for the escape pod!");
        }
        else if (currentSceneName == "Ending")
        {
            SetMessageText("You have arrived at Earth! or what is left of it...");
        }
        
    }
}



