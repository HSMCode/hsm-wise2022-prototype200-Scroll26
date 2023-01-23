using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCounter : MonoBehaviour
{
    public int destroyedEnemies;
    private int currentScore = 0;
    private Text scoreUI;
    public string scoreText = "Enemies: ";


    void Start()
    {
        scoreUI = this.gameObject.GetComponent<Text>();
        
    }


    void Update()
    {
        currentScore = destroyedEnemies;
        scoreUI.text = scoreText + currentScore.ToString();
        
    }
}
