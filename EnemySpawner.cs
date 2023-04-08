using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;  // The prefab of the enemy to spawn
    public float spawnRate = 1f;    // The time delay between each enemy spawn
    public float spawnRadius = 5f;  // The radius around the spawner where enemies can spawn
    public float spawnXMin = -2f;   // The minimum y-coordinate of the spawn position
    public float spawnXMax = 2f;    // The maximum y-coordinate of the spawn position

    private float timeSinceLastSpawn;  // The time elapsed since the last enemy spawn

    // Start is called before the first frame update
    void Start()
    {
        timeSinceLastSpawn = spawnRate;  // Set the time since last spawn to the spawn rate initially
    }

    // Update is called once per frame
    void Update()
    {
        // Increment the time since last spawn
        timeSinceLastSpawn += Time.deltaTime;

        // If enough time has elapsed since the last spawn, spawn a new enemy
        if (timeSinceLastSpawn >= spawnRate)
        {
            SpawnEnemy();
            timeSinceLastSpawn = 0f;  // Reset the time since last spawn
        }
    }

    void SpawnEnemy()
    {
        // Generate a random position within the spawn radius, with a y-coordinate between spawnYMin and spawnYMax
        float spawnX = Random.Range(spawnXMin, spawnXMax);
        Vector2 spawnPosition = (Vector2)transform.position + new Vector2(spawnX, 0);

        // Spawn the enemy at the generated position
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
