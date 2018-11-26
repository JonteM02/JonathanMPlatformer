using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WinnerWinnerChickenDinner : MonoBehaviour
{
    public string levelToLoad = "Scene 1";
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //Skriver ut winner winner chicken dinner i konsolen samt laddar scenen.
            print("Winner Winner Chicken Dinner");
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
