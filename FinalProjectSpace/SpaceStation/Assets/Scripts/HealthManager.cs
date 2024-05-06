using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    public int maxHealth = 100; //Max & Min allowed health
    public int minHealth = 0;
    private int currentHealth;  //Current health value

    public Text HealthText;  //Health Display in UI

    void Start()
    {
        //Set the starting health
        currentHealth = 50;
        //Initialize Display for health
        UpdateHealthDisplay();
    }

    void Update()
    {
        //End game if health reaches zero
        if (currentHealth <= minHealth)
        {
            SceneManager.LoadScene("FailScene");   //To be created later
        }
    }
 
    public void IncreaseHealth(int amount)
    {
        currentHealth += amount;
        currentHealth = Mathf.Min(currentHealth, maxHealth);  //Keeps health from going below zero  https://docs.unity3d.com/ScriptReference/Mathf.Min.html
        UpdateHealthDisplay();
    }

    public void DecreaseHealth(int amount)
    {
        currentHealth -= amount;
        currentHealth = Mathf.Max(currentHealth, minHealth); //Keeps health from going above 100 (max health)  https://docs.unity3d.com/ScriptReference/Mathf.Max.html
        UpdateHealthDisplay();
    }

    void UpdateHealthDisplay()
    {
        HealthText.text = "Health: " + currentHealth;
    }
}
