using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSound : MonoBehaviour
{
    private AudioSource _backgroundMusic;
    private InfoSaver _infoSaverScript;

    private void Start() 
    {
        _backgroundMusic = GetComponent<AudioSource>();
        _infoSaverScript = GameObject.Find("InfoSaver").GetComponent<InfoSaver>();
    }

    void Update()
    {
        //adjust sound volume
        _backgroundMusic.volume = _infoSaverScript.volume;

        //check for Paused or game over
        if (Time.timeScale == 0)
        {
            _backgroundMusic.Pause();
            
        }

        if (Time.timeScale == 1)
        {
            _backgroundMusic.UnPause();
        }
        
    }
}
