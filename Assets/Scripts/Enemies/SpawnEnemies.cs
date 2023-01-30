using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    private float _time = 0.0f;
    private float _secondsBetweenSpawns = 4f;
    private float _spawnHeight = 1f;
    public GameObject[] Enemies;
    private Vector3 _randomSpawnPosition;

    private float _randomSpawnX, _randomSpawnZ;
    private float _difficulty = 0f;
    private float _diffIncrease = 0.2f;


    
    void Start()
    {
        // spawn a single enemy when game starts
        spawnEnemy();
    }

    
    void Update()
    {
        // store seconds passed (since the last spawn) in a variable called time
        _time += Time.deltaTime;

        // if that number is equal to/bigger than the number of seconds between spawns
        if (_time >= _secondsBetweenSpawns - _difficulty)
        {
            // spawn another enemy
            spawnEnemy();
        }

    }


    private void spawnEnemy()
    {
        //reset the passed time since the last spawn to 0
        _time = 0.0f;

        //randomize a spawn position:
        int a = Random.Range(0, 2);
        switch (a)
        {
            case 0: //SpawnPositionX must be -10 or 10 and SpawnPositionZ a random number between -6 and 6.


                int b = Random.Range(0, 2);
                switch (b)
                {
                    case 0: // x is -10
                        _randomSpawnX = -10;
                        break;
                    case 1: // x is 10
                        _randomSpawnX = 10;
                        break;
                }
                _randomSpawnZ = Random.Range(-6, 7);

                break;

            case 1: //SpawnPositionZ must be -6 or 6 and SpawnPositionZ a random number between -10 and 10.
                int c = Random.Range(0, 2);
                switch (c)
                {
                    case 0: // z is -6
                        _randomSpawnZ = -6;
                        break;
                    case 1: // z is 6
                        _randomSpawnZ = 6;
                        break;
                }
                _randomSpawnX = Random.Range(-10, 11);
                break;
        }

        //store the spawn position
        _randomSpawnPosition = new Vector3(_randomSpawnX, _spawnHeight, _randomSpawnZ);

        //randomize an enemy listed in the array
        int randomIndex = Random.Range(0, Enemies.Length);

        //spawn the randomized enemy at the randomized position
        Instantiate(Enemies[randomIndex], _randomSpawnPosition, Quaternion.identity);


        //add to difficulty, which will increase spawnrate over time
        if(_difficulty < 3f)
        {
            _difficulty = _difficulty + _diffIncrease;
        }
    }
}
