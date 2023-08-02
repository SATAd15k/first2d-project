//Reference: https://github.com/CapelaGames/First2DProjectafteroon2023.2

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D PlayerRB;

    // Void returns nothing
    // Start Runs just before first frame
    private void Start()
    {
        // Define PlayerRB variable as a rigidbody2d; 
        PlayerRB = GetComponent<Rigidbody2D>();
    }
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
                PlayerRB = GetComponent<Rigidbody2D>();

                PlayerRB.AddForce(Vector2.up * 200f);
            }

        // Move Left

        if(Input.GetKey(KeyCode.LeftArrow) ||  Input.GetKey(KeyCode.S))
        {
            PlayerRB = GetComponent<Rigidbody2D>();

            PlayerRB.AddForce(Vector2.left * 2f);

            // Checking for x plane velocity; has to be a negative is moving left...

            /*if (PlayerRB.velocity.x > -2)
            {
                PlayerRB.velocity = new Vector2(-2, PlayerRB.velocity.y);
            }*/
        }

        // Move Right

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            PlayerRB = GetComponent<Rigidbody2D>();

            PlayerRB.AddForce(Vector2.right * 2f);

            /*if (PlayerRB.velocity.x > 2)
            {
                PlayerRB.velocity = new Vector2(2, PlayerRB.velocity.y);
            }*/
        }

        // Speed Limiter for x Plane
        // Have to use an else if to separate the movement on both directions on x plane or it override if using ||

        if (TryGetComponent<Rigidbody2D>(out PlayerRB))
                {
                    if (PlayerRB.velocity.x > 2)
                        {
                        PlayerRB.velocity = new Vector2(2, PlayerRB.velocity.y);
                        }
                    else if (PlayerRB.velocity.x < -2)
                        {
                        PlayerRB.velocity = new Vector2(-2, PlayerRB.velocity.y);
                        }
                }

        // Speed Limiter for y Plane (test)

        if (TryGetComponent<Rigidbody2D>(out PlayerRB))
        {
            if (PlayerRB.velocity.y > 2)
            {
                PlayerRB.velocity = new Vector2(PlayerRB.velocity.x, 2);
            }
            else if (PlayerRB.velocity.y < -2)
            {
                PlayerRB.velocity = new Vector2(PlayerRB.velocity.x, -20);
            }
        }

    }
}
