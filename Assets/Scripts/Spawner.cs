using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    void Start()
    {
        SpawnEnemy();
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
    }
}