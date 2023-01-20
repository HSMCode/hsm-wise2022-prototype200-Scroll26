using System.Collections;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;

public class MoveEnemy : MonoBehaviour
{
    private Transform Player;
    private Vector3 movement;
    public float enemySpeed = 2f;
   
    // Start is called before the first frame update
    void Start()
    {
       
      
    }

    // Update is called once per frame
    void Update()
    {   
        //find the player and store its position
        Player = GameObject.Find("Player").transform;

        //calculate and store the enemies direction
        Vector3 direction = Player.position - transform.position;

        movement = direction;
        movement.Normalize();
    }

    private void FixedUpdate()
    {
        //execute the enemy movement once per frame
        moveCharacter(movement);
    }

    void moveCharacter(Vector3 direction)
    {   
        //move the enemy
        transform.position = (Vector3)transform.position + (direction * enemySpeed * Time.deltaTime);
    }
}
