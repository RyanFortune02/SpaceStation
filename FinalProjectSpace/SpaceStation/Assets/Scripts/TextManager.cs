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

        if (currentSceneName == "Cryoscene")
        {
            SetMessageText("Welcome! You have just woken from Cryosleep! Look to your left for instructions.");
        }
        else if (currentSceneName == "SpaceHallway")
        {
            SetMessageText("Escape randomly floating objects\r\nFind food resources for health \r\n");
        }
        else  //
        {
            SetMessageText("Welcome to the end scene");
        }
    }

    void Update()
    {

    }
}



