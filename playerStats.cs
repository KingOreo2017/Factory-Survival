using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerStats : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    float hungerLoss = -100f;
    float staminaLoss = -5;
    Vector2 position1 = Vector2.zero;
    Vector2 position2 = Vector2.zero;
    public static bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver == false)
        {
            position1 = position2;
            position2 = myRigidbody.position;
            Vector2 speed = (position2 - position1) / Time.deltaTime;
            //Debug.Log(myRigidBody.velocity);
            if (logicScript.playerHunger > 0)
            {
                logicScript.hungerChange(hungerLoss);
            }
            //Debug.Log(speed);
            if (speed.magnitude > 0 && logicScript.playerStamina > 0)
            {
                logicScript.staminaChange(staminaLoss); //changes the stamina by variable staminaLoss every tick if they player is moving
            }
            if (speed.magnitude <= 0 && logicScript.playerStamina < 100)
            {
                logicScript.staminaChange(staminaLoss * -3); // Changes the stamina by the inverse (times 3 for increased stamina regen) of staminaLoss if the player is still
            }
            if (logicScript.playerHunger <= 0)
            {
                logicScript.playerHealth -= 0.1f;
                if (logicScript.playerHealth <= 0)
                {
                    gameOver = true;
                }
            }
            //Debug.Log(logicScript.playerStamina);
        }
    }
}