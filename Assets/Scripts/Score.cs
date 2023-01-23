using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int destroyedEnemies;
    private int currentScore = 0;
    public int Time;
    private int currentTime = 0;
    private Text scoreUI;
    
    void Start()
    {
        scoreUI = this.gameObject.GetComponent<Text>();
    }

    
    void Update()
    {
        currentScore = destroyedEnemies;
        currentTime = Time;
        scoreUI.text = "Time Survived: " + currentTime.ToString() + " sec" + "\nEnemies killed: " + currentScore.ToString();
        
    }
}
