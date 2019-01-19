using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    private float speed = 6;
    void OnTriggerStay2D(Collider2D other)
    {
        //Om spelaren trycker på W på stegen så kommer han att röra sig uppåt
        if (other.tag == "Player" && Input.GetKey(KeyCode.W))
        {
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
        }
        //Om spelaren trycker på S på sten så kommer han att röra sig neråt
        else if (other.tag == "Player" && Input.GetKey(KeyCode.S))
        {
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
        }
        //Om spelaren inte gör någonting kommer man att röra sig neråt långsamt
        else
        {
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
        }
    }

}
