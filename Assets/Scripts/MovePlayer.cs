using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private float horizontalInput;
    private float forwardInput;
    [SerializeField] float turnSpeed;    
    [SerializeField] float speed;
    public bool right;
    private SpriteFlip _spriteFlipScript;
    
    
    void Start()
    {
        _spriteFlipScript = GameObject.Find("Little_Soul").GetComponent<SpriteFlip>();
    }

    // Spielerbewegung 
    void Update()
    {
      horizontalInput = Input.GetAxis("Horizontal");  
      transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

      forwardInput = Input.GetAxis("Vertical"); 
      transform.Translate(Vector3.forward * forwardInput * Time.deltaTime * speed);


      //check for movement direction
      if (horizontalInput > 0)
      {
        right = true;
        _spriteFlipScript.flip = true;
      }
      else if (horizontalInput < 0)
      {
        right = false;
        _spriteFlipScript.flip = false;
      }
    }
}
