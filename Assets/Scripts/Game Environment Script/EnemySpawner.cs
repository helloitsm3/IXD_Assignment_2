using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{

    public int numOfEnemies;
    public GameObject enemyPrefb;
    public Transform enemySpawnPoint;
    public float maxSpawnTimer;
    bool isSpawn;

    private float spawnTimer;

    // Use this for initialization
    void Start()
    {
        isSpawn = true;
        spawnTimer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (isSpawn)
        {
            while (numOfEnemies != 0 && isSpawn == true)
            {
                Debug.Log("SPAWNED");
                GameObject enemy = Instantiate(this.enemyPrefb, this.enemySpawnPoint.position, this.enemySpawnPoint.rotation) as GameObject;
                numOfEnemies--;
                isSpawn = false;
            }

            while (spawnTimer < 1f && isSpawn == false)
            {
                spawnTimer += 0.1f;
                isSpawn = true;
            }
        }
    }
}
