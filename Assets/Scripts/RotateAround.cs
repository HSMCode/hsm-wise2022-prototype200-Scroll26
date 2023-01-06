using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class RotateAround : MonoBehaviour
{

    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Drehbewegung des Balles 
    void Update()
    {
          transform.Rotate(new Vector3(0, rotationSpeed, 0) * Time.deltaTime);
    }


    
}
