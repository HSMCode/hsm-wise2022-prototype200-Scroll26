using System.Collections;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;

public class MoveEnemyGhost : MonoBehaviour
{
    private Transform _player;
    private Vector3 _movement;
    private float _enemySpeed = 2f;
    private EnemyCounter _enemyCounterScript;
    private SpriteFlip _spriteFlipScript;
   
    
    void Start()
    {
        _enemyCounterScript = GameObject.Find("EnemyCounter").GetComponent<EnemyCounter>();
        _spriteFlipScript = transform.Find("Ghost_Walk_1").GetComponent<SpriteFlip>();
    }

    
    void Update()
    {   
        //find the player and store its position
        _player = GameObject.Find("Player").transform;

        //calculate and store the enemies direction
        Vector3 direction = _player.position - transform.position;

        _movement = direction;
        _movement.Normalize();

        //check for movement direction
      if (direction.x > 0)
      {
        _spriteFlipScript.flip = true;
      }
      else if (direction.x < 0)
      {
        _spriteFlipScript.flip = false;
      }
    }

    private void FixedUpdate()
    {
        //execute the enemy movement once per frame
        moveCharacter(_movement);
    }

    void moveCharacter(Vector3 direction)
    {   
        //move the enemy
        transform.position = (Vector3)transform.position + (direction * _enemySpeed * Time.deltaTime);
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
