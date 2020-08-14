using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Enemy Way Config")]
public class WaveConfig : ScriptableObject
{
    [SerializeField] GameObject enemyPrefabs;
    [SerializeField] GameObject pathPrefabs;
    [SerializeField] float timeBetweenSpawns = 0.5f;
    [SerializeField] float spawnRandomFactor = 0.3f;
    [SerializeField] int numberOfEnemies = 10;
    [SerializeField] float moveSpeed = 2f;

    public GameObject getEnemyPrefabs() { return enemyPrefabs; }

    public List<Transform> getWaypoints()
    {
        var waveWaypoints = new List<Transform>();
        foreach(Transform child in pathPrefabs.transform)
        {
            waveWaypoints.Add(child);
        }
        return waveWaypoints;
    }

    public float getTimeBetweenSpawns() { return timeBetweenSpawns; }

    public float getSpawnRandomFactor() { return spawnRandomFactor; }

    public int getNumberOfEnemies() { return numberOfEnemies; }

    public float getMoveSpeed() { return moveSpeed; }
}
