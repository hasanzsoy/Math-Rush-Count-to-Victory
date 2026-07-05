using System.Collections;
using UnityEngine;

public class SpawnerSystem : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform player;

    public float spawnTime = 2f;
    public float minSpawnTime = 0.5f;

    public int maxEnemy = 7;

    private int currentEnemy = 0;
    private bool isRunning = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isRunning = !isRunning;

            if (isRunning)
                StartCoroutine(SpawnEnemies());
            else
                StopAllCoroutines();
        }
    }

    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            if (currentEnemy < maxEnemy)
            {
                Spawn();
            }

            yield return new WaitForSeconds(spawnTime);

           
            if (spawnTime > minSpawnTime)
            {
                spawnTime -= 0.2f;
            }
        }
    }

    void Spawn()
    {
        Vector3 pos = RandomPosition();

        GameObject enemy = Instantiate(enemyPrefab, pos, Quaternion.identity);

        currentEnemy++;

        //prefabdeki yere koyduklarım
        enemy.GetComponent<Enemy>().player = player;
        enemy.GetComponent<Enemy>().spawner = this;
    }

    Vector3 RandomPosition()
    {
        Vector3 random = Random.insideUnitSphere * 10f;
        random.y = 0;

        Vector3 pos = player.position + random;

        
        if (Vector3.Distance(pos, player.position) < 3f)
        {
            return RandomPosition();
        }

        return pos;
    }

    public void EnemyDied()
    {
        currentEnemy--;
    }

    public int GetEnemyCount()
    {
        return currentEnemy;
    }
}