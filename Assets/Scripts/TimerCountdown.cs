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



void Update()
{

   if(deductingTime==false)
   {
       deductingTime = true;
        StartCoroutine(AddSecond());

   }
}
//Wenn die Coroutine angehalten werden soll (GameOver), einfach bool positiv setzen in ner seperaten if-Funktion :handshake:
   IEnumerator AddSecond()
   {
       yield return new WaitForSeconds(1);
       seconds+=1;
       timeDisplay.GetComponent<Text>().text = "Time: " + seconds;
       deductingTime = false;
   }
   
}