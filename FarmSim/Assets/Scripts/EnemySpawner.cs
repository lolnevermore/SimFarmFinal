using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float initialSpawnDelay = 6.0f;
    public float spawnInterval = 5.0f;
    public Transform spawnPoint;


    private float timer = 0.0f;
    public Score score;

    void Start()
    {
       // score = GetComponent<Score>();
        InvokeRepeating("SpawnEnemy", initialSpawnDelay, spawnInterval);
    }

    void SpawnEnemy()
    {
        if (score.score > 0)
        {
            Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
        }
    }

}