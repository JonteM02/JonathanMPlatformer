using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetInvisible : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //Hämtar componenten som heter spriterenderer och stänger av den vilket gör den osynlig.
        GetComponent<SpriteRenderer>().enabled = false;
    }

}
