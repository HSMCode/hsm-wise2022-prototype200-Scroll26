using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteFlip : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer; 
    public bool flip;

    
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        
    }

    
    void Update()
    {
        //flip the sprite according to movement direction
        if (flip)
        {
            _spriteRenderer.flipX = true;
        }
        else
        {
            _spriteRenderer.flipX = false;
        }
        
    }
}
