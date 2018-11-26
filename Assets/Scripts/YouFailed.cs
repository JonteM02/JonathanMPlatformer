using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouFailed : MonoBehaviour
{
    public string levelToLoad = "Scene 1";
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Skriv ut i konsollen att du har Failat.
            print("You Failed");
            //Ladda aktiva scenen dvs om du är på level 2 så laddar den level 2 istället för level 1.
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
