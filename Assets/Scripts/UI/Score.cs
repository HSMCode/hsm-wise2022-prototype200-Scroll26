using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int destroyedEnemies;
    private int _currentScore = 0;
    public int Time;
    private int _currentTime = 0;
    private Text _scoreUI;
    
    void Start()
    {
        _scoreUI = this.gameObject.GetComponent<Text>();
    }

    
    void Update()
    {
        //update score 
        _currentScore = destroyedEnemies;
        _currentTime = Time;
        _scoreUI.text = "Time Survived: " + _currentTime.ToString() + " sec" + "\nEnemies killed: " + _currentScore.ToString();  
    }
}
