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
        rbody = GetComponent<Rigidbody2D>();
        Move(false);
    }

    void Move(bool flip)
    {
        if (flip == true)
        {
            isleft = !isleft;
        }
        if (isleft == true)
        {
            rbody.velocity = new Vector2(-moveSpeed, rbody.velocity.y);
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            rbody.velocity = new Vector2(moveSpeed, rbody.velocity.y);
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "InvisibleWall")
        {
            Move(true);
        }
    }
}
