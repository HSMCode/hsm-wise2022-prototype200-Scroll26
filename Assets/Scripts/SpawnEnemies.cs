using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    private float time = 0.0f;
    public float secondsBetweenSpawns = 4f;
    public float spawnHeight = 1f;
    public GameObject[] Enemies;
    Vector3 randomSpawnPosition;

    private float randomSpawnX, randomSpawnZ;
    public float difficulty = 0f;
    public float diffIncrease = 0.2f;


    // Start is called before the first frame update
    void Start()
    {
        // spawn a single enemy when game starts
        spawnEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        // store seconds passed (since the last spawn) in a variable called time
        time += Time.deltaTime;

        // if that number is equal to/bigger than the number of seconds between spawns
        if (time >= secondsBetweenSpawns - difficulty)
        {
            // spawn another enemy
            spawnEnemy();
        }

    }


    private void spawnEnemy()
    {
        //reset the passed time since the last spawn to 0
        time = 0.0f;

        //randomize a spawn position:
        int a = Random.Range(0, 2);
        switch (a)
        {
            case 0: //SpawnPositionX must be -10 or 10 and SpawnPositionZ a random number between -6 and 6.


                int b = Random.Range(0, 2);
                switch (b)
                {
                    case 0: // x is -10
                        randomSpawnX = -10;
                        break;
                    case 1: // x is 10
                        randomSpawnX = 10;
                        break;
                }
                randomSpawnZ = Random.Range(-6, 7);

                break;

            case 1: //SpawnPositionZ must be -6 or 6 and SpawnPositionZ a random number between -10 and 10.
                int c = Random.Range(0, 2);
                switch (c)
                {
                    case 0: // z is -6
                        randomSpawnZ = -6;
                        break;
                    case 1: // z is 6
                        randomSpawnZ = 6;
                        break;
                }
                randomSpawnX = Random.Range(-10, 11);
                break;
        }

        //store the spawn position
        randomSpawnPosition = new Vector3(randomSpawnX, spawnHeight, randomSpawnZ);

        //randomize an enemy listed in the array
        int randomIndex = Random.Range(0, Enemies.Length);

        //spawn the randomized enemy at the randomized position
        Instantiate(Enemies[randomIndex], randomSpawnPosition, Quaternion.identity);


        //add to difficulty, which will increase spawnrate over time
        if(difficulty < 3.6f)
        {
            difficulty = difficulty + diffIncrease;
        }
    }
}
