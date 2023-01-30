using System.Collections;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;

public class MoveEnemyGhoul : MonoBehaviour
{
    private Transform Player;
    private Vector3 movement;
    public float enemySpeed = 2f;
    private EnemyCounter _enemyCounterScript;
    private SpriteFlip _spriteFlipScript;
    public bool right;
   
    
    void Start()
    {
        _enemyCounterScript = GameObject.Find("EnemyCounter").GetComponent<EnemyCounter>();
        _spriteFlipScript = transform.Find("Ghoul_Walk_1").GetComponent<SpriteFlip>();
    }

    
    void Update()
    {   
        //find the player and store its position
        Player = GameObject.Find("Player").transform;

        //calculate and store the enemies direction
        Vector3 direction = Player.position - transform.position;

        movement = direction;
        movement.Normalize();

        //check for movement direction
      if (direction.x > 0)
      {
        right = true;
        _spriteFlipScript.flip = true;
      }
      else if (direction.x < 0)
      {
        right = false;
        _spriteFlipScript.flip = false;
      }
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
