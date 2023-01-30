using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicOptions : MonoBehaviour
{

    private AudioSource _menuMusic;
    public float volume;
    private InfoSaver _infoSaverScript;


    void Start()
    {
        _menuMusic = GetComponent<AudioSource>();
        _infoSaverScript = GameObject.Find("InfoSaver").GetComponent<InfoSaver>();
    }


    void Update()
    {
        //adjust sound volume
        _menuMusic.volume = _infoSaverScript.volume;       
    }
}
