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
            print("You Failed");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
