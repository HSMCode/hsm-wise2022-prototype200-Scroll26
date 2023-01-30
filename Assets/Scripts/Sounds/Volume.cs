using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{

    private Slider _volumeSlider;
    private InfoSaver _infoSaverScript;

    void Start()
    {
        _volumeSlider = GetComponent<Slider>();
        _infoSaverScript = GameObject.Find("InfoSaver").GetComponent<InfoSaver>();
        _volumeSlider.value = _infoSaverScript.volume;
    }

    void Update()
    {   
        //save volume in Info Saver Script
        _infoSaverScript.volume = _volumeSlider.value;
    }
}
