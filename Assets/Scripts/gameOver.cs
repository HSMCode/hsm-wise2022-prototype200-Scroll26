using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOver : MonoBehaviour
{
    private bool GameOver = false;
    public GameObject gameOverPanel;

    // Start is called before the first frame update
    void Start()
    {   
        //reset game over to false 
        GameOver = false;
        //and the time normal in case the game has been restarted.
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //if the game is over
        if (GameOver)
        {   
            //pause the time
            Time.timeScale = 0;
            //and show the game over panel
            gameOverPanel.SetActive(true);
        }
    }

    
    private void OnCollisionEnter(Collision collision)
    {
        //if the player collides with an object tagged with "Enemy"
        if (collision.transform.tag == "Enemy")
        {   
            //set the game over bool to true
            GameOver = true;
        }
    }
}
