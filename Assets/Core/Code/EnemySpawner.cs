using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemyPrefab;   // Prefab del nemico
    public float spawnRate = 2f;     // ogni quanti secondi spawnare
    public float minY = -3f, maxY = 3f; // range verticale dello spawn
    public float spawnX = 10f;       // posizione orizzontale (a destra dello schermo)
    private int EnemySpawn = 0;
    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 1f, spawnRate);
    }

    void SpawnEnemy()
    {
        float y = Random.Range(minY, maxY);
        Vector3 pos = new Vector3(spawnX, y, 0);
        int randomIndex = Random.Range(0, enemyPrefab.Length);
        Instantiate(enemyPrefab[randomIndex], pos, Quaternion.Euler(0, 0, -90));
    }
}