using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private float _horizontalInput;
    private float _forwardInput;    
    private float _speed = 5;
    private SpriteFlip _spriteFlipScript;
    
    
    void Start()
    {
        _spriteFlipScript = GameObject.Find("Little_Soul").GetComponent<SpriteFlip>();
    }

    // Spielerbewegung 
    void Update()
    {
      _horizontalInput = Input.GetAxis("Horizontal");  
      transform.Translate(Vector3.right * _horizontalInput * Time.deltaTime * _speed);

      _forwardInput = Input.GetAxis("Vertical"); 
      transform.Translate(Vector3.forward * _forwardInput * Time.deltaTime * _speed);


      //check for movement direction
      if (_horizontalInput > 0)
      {
        _spriteFlipScript.flip = true;
      }
      else if (_horizontalInput < 0)
      {
        _spriteFlipScript.flip = false;
      }
    }
}
