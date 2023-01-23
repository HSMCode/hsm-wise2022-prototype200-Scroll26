using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCounter : MonoBehaviour
{
    public int destroyedEnemies;
    public int survivedTime;
    private int currentScore = 0;
    private Text scoreUI;
    public string scoreText = "Enemies: ";
    public bool gameOver = false;
    private Score _scoreScript;


    void Start()
    {
        scoreUI = this.gameObject.GetComponent<Text>();  
    }


    void Update()
    {
        //Update the Score for destroyed enemies
        currentScore = destroyedEnemies;
        scoreUI.text = scoreText + currentScore.ToString();

        
    }

    void LateUpdate() 
    {
        //When Game Over, push the counters to the score script
        if (gameOver)
        {
            _scoreScript = GameObject.Find("Score").GetComponent<Score>();
            _scoreScript.destroyedEnemies = currentScore;
            _scoreScript.Time = survivedTime;
        }
    }
}
