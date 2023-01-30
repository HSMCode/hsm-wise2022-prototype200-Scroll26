using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicOptions : MonoBehaviour
{

    private AudioSource _menuMusic;
    public float volume;


    void Start()
    {
        _menuMusic = GetComponent<AudioSource>();
        
    }


    void Update()
    {
        _menuMusic.volume = volume;       
    }
}
