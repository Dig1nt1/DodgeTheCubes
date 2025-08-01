using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject fallingCubePrefab;
    public float spawnRate = 1f;
    public float spawnRangeX = 5f;

    void Start()
    {
        InvokeRepeating("SpawnCube", 1f, spawnRate);
    }

    void SpawnCube()
    {
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);
        Vector3 spawnPos = new Vector3(randomX, 10f, 0);
        Instantiate(fallingCubePrefab, spawnPos, Quaternion.identity);
    }
}
