using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public Image healthBar;
    public Image staminaBar;
    public Image hungerBar;
    public Text gameOverScreen;
    public float playerHealth;
    public float playerStamina;
    public float playerHunger;
    //public playerStats PlayerStats;
    void Update()
    {
        playerHealth = logicScript.playerHealth;
        playerStamina = logicScript.playerStamina;
        playerHunger = logicScript.playerHunger;
        healthBar.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, playerHealth);
        staminaBar.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, playerStamina);
        hungerBar.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, playerHunger);
        UnityEngine.Debug.Log(playerStats.gameOver);
        if (playerStats.gameOver == true)
        {
            gameOverScreen.enabled = true;
        }
    }
}
