using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // use 2 pipes as an OR use 2 ampersand as needing both to be held
        // Always use brackets if needing and OR or BOTH
        // bool jumpInput = (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow));
        // Debug.Log(jumpInput);

        //Jump Function using either SPACE or UPARROW

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
            {
                Rigidbody2D PlayerRB = GetComponent<Rigidbody2D>();

                PlayerRB.AddForce(Vector2.up * 200f);
            }

        // Move Left

        if(Input.GetKey(KeyCode.LeftArrow) ||  Input.GetKey(KeyCode.S))
        {
            Rigidbody2D PlayerRB = GetComponent<Rigidbody2D>();

            PlayerRB.AddForce(Vector2.left * 20f);

            // Checking for x plane velocity; has to be a negative is moving left...

            if (PlayerRB.velocity.x > -20)
            {
                PlayerRB.velocity = new Vector2(-20, PlayerRB.velocity.y);
            }
        }

        // Move Right

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            Rigidbody2D PlayerRB = GetComponent<Rigidbody2D>();

            PlayerRB.AddForce(Vector2.right * 20f);

            if (PlayerRB.velocity.x > 20)
            {
                PlayerRB.velocity = new Vector2(20, PlayerRB.velocity.y);
            }
        }

        // Speed Limiter

        if (Rigidbody2D PlayerRB =  GetComponent<Rigidbody2D>())
                {
                    
                }
    }
}
