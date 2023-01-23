using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int destroyedEnemies;
    private int currentScore = 0;
    private Text scoreUI;
    
    void Start()
    {
        scoreUI = this.gameObject.GetComponent<Text>();
    }

    
    void Update()
    {
        currentScore = destroyedEnemies;
        scoreUI.text = "Time Survived:" + "\nEnemies killed: " + currentScore.ToString();
        
    }
}
