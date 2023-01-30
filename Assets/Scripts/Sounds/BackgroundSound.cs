using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSound : MonoBehaviour
{
    private AudioSource _backgroundMusic;

    private void Start() 
    {
        _backgroundMusic = GetComponent<AudioSource>();
    }

    void Update()
    {
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
