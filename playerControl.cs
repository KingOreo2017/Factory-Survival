using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float moveSpeed = 5f;
    public float worldBoarderposY;
    public float worldBoardernegY;
    public float worldBoarderposX;
    public float worldBoardernegX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int rotation = 0;
        int totalInputs = 0;
        if (Input.GetKey(KeyCode.W) && logicScript.playerStamina > 0 && myRigidbody.position.y < worldBoarderposY)
        {
            myRigidbody.position += Vector2.up * Time.deltaTime * moveSpeed;
            rotation += 0;
            totalInputs += 1;
        }
        if (Input.GetKey(KeyCode.S) && logicScript.playerStamina > 0 && myRigidbody.position.y > worldBoardernegY)
        {
            myRigidbody.position += Vector2.down * Time.deltaTime * moveSpeed;
            if (Input.GetKey(KeyCode.D))
            {
                rotation += -180;
            }
            else
            {
                rotation += 180;
            }
            totalInputs += 1;
        }
        if (Input.GetKey(KeyCode.A) && logicScript.playerStamina > 0 && myRigidbody.position.x > worldBoardernegX)
        {
            myRigidbody.position += Vector2.left * Time.deltaTime * moveSpeed;
            rotation += 90;
            totalInputs += 1;
        }
        if (Input.GetKey(KeyCode.D) && logicScript.playerStamina > 0 && myRigidbody.position.x < worldBoarderposX)
        {
            myRigidbody.position += Vector2.right * Time.deltaTime * moveSpeed;
            rotation += -90;
            totalInputs += 1;
        }
        if (totalInputs > 0)
        {
            myRigidbody.rotation = rotation / totalInputs;
        }
        //Debug.Log(myRigidbody.position);
        //Debug.Log(myRigidbody.velocity.magnitude);
    }
}
