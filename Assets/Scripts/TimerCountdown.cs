using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimerCountdown : MonoBehaviour
{
    public GameObject timeDisplay;
    public int seconds = 0;
    // bool is anfangs immer falsch, daher startet Coroutine direkt
    public bool deductingTime;
    private EnemyCounter _enemyCounterScript;


void Start() 
{
    _enemyCounterScript = GameObject.Find("EnemyCounter").GetComponent<EnemyCounter>();
}


void Update()
{

   if(deductingTime==false)
   {
       deductingTime = true;
        StartCoroutine(AddSecond());
   }

   _enemyCounterScript.survivedTime = seconds;
}

   IEnumerator AddSecond()
   {
       yield return new WaitForSeconds(1);
       seconds+=1;
       timeDisplay.GetComponent<Text>().text = "Time: " + seconds;
       deductingTime = false;
   }
   
}