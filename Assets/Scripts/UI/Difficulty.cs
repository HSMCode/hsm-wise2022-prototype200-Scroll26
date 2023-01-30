using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Difficulty : MonoBehaviour
{
    private Slider _difficultySlider;
    private InfoSaver _infoSaverScript;

    void Start()
    {
        _difficultySlider = GetComponent<Slider>();
        _infoSaverScript = GameObject.Find("InfoSaver").GetComponent<InfoSaver>();

        //get default/previous value from Info Saver Script
        _difficultySlider.value = _infoSaverScript.difficulty;      
    }


    void Update()
    {
        //save difficulty in Info Saver Script
        _infoSaverScript.difficulty = _difficultySlider.value;
    }
}
