using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    public int maxHealth = 100; //Max & Min allowed health
    public int minHealth = 0;
    public int currentHealth;  //Current health value set in inspector

    public Text HealthText;  //Health Display in UI


    void Start()
    {
        //Set the starting health (trying to use inspector to change health for each level.
        //currentHealth = 50;
        //Initialize Display for health
        UpdateHealthDisplay();
    }

    void Update()
    {
        //End game if health reaches zero (that is what minimum health is set to in inspector)
        if (currentHealth <= minHealth)
        {
            LoadScene("FailScene");
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

    private void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
