using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHofizontalMovement : MonoBehaviour
{
    public float moveSpeed = 2f;
    private bool isleft = true;
    private Rigidbody2D rbody;
    // Use this for initialization
    void Start()
    {
        //Hämtar componenten Rigidbody2D när man startar spelet.
        rbody = GetComponent<Rigidbody2D>();
        //Kör movefunktionen och bestämmer vad flip ska vara
        Move(false);
    }

    void Move(bool flip)
    {
        //Om flip är sann så händer något.
        if (flip == true)
        {
            //Om isleft är !isleft så flippar den.
            isleft = !isleft;
        }
        //om isleft är true så händer det en sak.
        if (isleft == true)
        {
            //Om isleft är sann så byter den så att den går åt vänster.
            rbody.velocity = new Vector2(-moveSpeed, rbody.velocity.y);
            //Om isleft är sann så byter den håll så att spriten är åt höger istället för vänster.
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            //Om isleft är false så rör sig motståndaren sig åt höger.
            rbody.velocity = new Vector2(moveSpeed, rbody.velocity.y);
            //Om isleft är false så byter spriten håll till vänster.
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
    //Detta är en void som gör att när min karaktär går in i något så trigras något.
    void OnTriggerEnter2D(Collider2D collision)
    {
        //Om taggen på ett object är InvisibleWall så sätts Move på
        if (collision.tag == "InvisibleWall")
        {
            Move(true);
        }
    }
}
