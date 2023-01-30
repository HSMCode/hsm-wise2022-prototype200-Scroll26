using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class RotateAround : MonoBehaviour
{

    private float _rotationSpeed = 200;
    

    // Drehbewegung des Balles 
    void Update()
    {
          transform.Rotate(new Vector3(0, _rotationSpeed, 0) * Time.deltaTime);
    }


    
}
