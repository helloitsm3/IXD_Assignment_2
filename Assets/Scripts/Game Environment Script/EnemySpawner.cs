using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

    public int numOfEnemies;
    public GameObject enemyPrefb;
    public Transform enemySpawnPoint;
    bool isSpawn;

	// Use this for initialization
	void Start () {
        isSpawn = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (isSpawn)
        {
            while (numOfEnemies != 0)
            {
                GameObject enemy = Instantiate(this.enemyPrefb, this.enemySpawnPoint.position, this.enemySpawnPoint.rotation) as GameObject;
                numOfEnemies--;
            }

            isSpawn = false;
        }
    }
}
