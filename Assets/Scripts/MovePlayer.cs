using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private float horizontalInput;
     private float forwardInput;
     [SerializeField] float turnSpeed;    
    [SerializeField] float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Spielerbewegung (hast du mir gezeigt lol)
    void Update()
    {
      horizontalInput = Input.GetAxis("Horizontal");  
      transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

       forwardInput = Input.GetAxis("Vertical"); 
       transform.Translate(Vector3.forward * forwardInput * Time.deltaTime * speed);
    }
}
