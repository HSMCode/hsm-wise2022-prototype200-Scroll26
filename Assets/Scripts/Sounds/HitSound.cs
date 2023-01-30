using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitSound : MonoBehaviour
{
    
    private AudioSource _hitSound;
    private InfoSaver _infoSaverScript;

    void Start()
    {
        //get Audio Source component
        _hitSound = GetComponent<AudioSource>();
        _infoSaverScript = GameObject.Find("InfoSaver").GetComponent<InfoSaver>();
        
    }

    void Update()
    {
        //adjust hit sound volume
        _hitSound.volume = _infoSaverScript.volume;       
    }

    private void OnCollisionEnter(Collision collision) 
    {
        //when hitting an enemy, play sound
        if (collision.gameObject.CompareTag("Enemy"))
        {
            _hitSound.Play();
        }
        
    }
}
