using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int score = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //skapa en temprär variabel "controller" och sätt den till reultatet
            //av sökningen efter objektet med taggen "GameController"
            GameObject controller = GameObject.FindWithTag("GameController");
            if (controller != null)
            {
                //skapa en temporär variabel "tracker" och sätt den till
                //resultatet av sökningen efter komponenten "ScoreTracker".
                ScoreTracker tracker = controller.GetComponent<ScoreTracker>();
                if (tracker != null)
                {
                    //Håller koll på vilket score playern har. 
                    tracker.totalScore += score;
                }
                else
                {
                    //Varnar i loggen om ScoreTracker inte finns på GameController.
                    Debug.LogError("ScoreTracker saknas på GameController");
                }
            }
            else
            {
                //Varnar för att GameControllern inte finns
                Debug.LogError("GameController finns inte");
            }
            Destroy(gameObject);
        }
    }
}