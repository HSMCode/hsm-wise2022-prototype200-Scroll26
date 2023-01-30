using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitSound : MonoBehaviour
{
    
    private AudioSource _hitSound;

    void Start()
    {
        //get Audio Source component
        _hitSound = GetComponent<AudioSource>();
        
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
