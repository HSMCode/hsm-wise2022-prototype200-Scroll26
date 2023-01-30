using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimerCountdown : MonoBehaviour
{
    public GameObject timeDisplay;
    private int _seconds = 0;
    // bool is anfangs immer falsch, daher startet Coroutine direkt
    private bool _deductingTime;
    private EnemyCounter _enemyCounterScript;


void Start() 
{
    _enemyCounterScript = GameObject.Find("EnemyCounter").GetComponent<EnemyCounter>();
}


void Update()
{

   if(_deductingTime==false)
   {
       _deductingTime = true;
        StartCoroutine(AddSecond());
   }

    //push survived seconds to enemy counter script for highscore
   _enemyCounterScript.survivedTime = _seconds;
}

    //Timer
   IEnumerator AddSecond()
   {
       yield return new WaitForSeconds(1);
       _seconds += 1;
       timeDisplay.GetComponent<Text>().text = "Time: " + _seconds;
       _deductingTime = false;
   }
   
}