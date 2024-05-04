using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public Text MessageText;


    public void SetMessageText(string message)
    {
        MessageText.text = message;
    }

    void Start()
    {
        SetMessageText("Welcome! You have just woken from Cyrosleep! Look to your left for instructions."); // Welcome message
    }

    void Update()
    {
        
    }
}
