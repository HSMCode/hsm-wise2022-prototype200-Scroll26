using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOver : MonoBehaviour
{
    private bool _gameOver = false;
    public GameObject gameOverPanel;
    private EnemyCounter _enemyCounterScript;


    void Start()
    {   
        //reset game over to false 
        _gameOver = false;
        //and the time normal in case the game has been restarted.
        Time.timeScale = 1;

        //find the enemy counter script to calculate the final score when game over
        _enemyCounterScript = GameObject.Find("EnemyCounter").GetComponent<EnemyCounter>();

    }

    
    void Update()
    {
        //if the game is over
        if (_gameOver)
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
            _gameOver = true;
            //give the Enemy counter script the game over bool for the final score
            _enemyCounterScript.gameOver = true;
        }
    }
}
