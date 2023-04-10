using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class logicScript : MonoBehaviour
{
    public static float playerHealth = 100;
    public static float playerStamina = 100;
    public static float playerHunger = 100;
    
    public static void healthChange(float health)
    {
        playerHealth += health * Time.deltaTime;
    }
    public static void staminaChange(float stamina)
    {
        playerStamina += stamina * Time.deltaTime;
    }
    public static void hungerChange(float hunger)
    {
        playerHunger += hunger * Time.deltaTime;
    }
    
}
