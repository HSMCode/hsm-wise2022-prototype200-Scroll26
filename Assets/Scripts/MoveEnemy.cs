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
    private EnemyCounter _enemyCounterScript;
   
    
    void Start()
    {
        _enemyCounterScript = GameObject.Find("EnemyCounter").GetComponent<EnemyCounter>();
    }

    
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

    private void OnCollisionEnter(Collision collision) 
    {
        //when hit by the weapon, update the score and destroy the enemy game object
        if (collision.gameObject.CompareTag("Weapon"))
        {
            _enemyCounterScript.destroyedEnemies++;
            
            Destroy(this.gameObject);
            
        }
        
    }
}
