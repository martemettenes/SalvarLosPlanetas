using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemyPrefab;

    public List<Sprite> badWords = new List<Sprite>();

    public static int enemiesSpawned;
    float rand;

    int enemySpawnAmount = 5;


    private void Start()
    {
        enemiesSpawned = 0;

        InvokeRepeating("SpawnEnemy", 1, 1);
    }

    private void Update()
    {
        if (GameOverText.gameOver == true || WinText.completeLevel == true)
        {
            CancelInvoke("SpawnEnemy");
        }

        if (enemiesSpawned >= enemySpawnAmount)
        {
            CancelInvoke("SpawnEnemy");
            InvokeRepeating("SpawnEnemy", 8, 1);
            enemiesSpawned = 0;

            enemySpawnAmount++;
        }
    }


    public void SpawnEnemy ()
    {
        GameObject enemy = Instantiate(enemyPrefab) as GameObject;
        while (Vector2.Distance(enemy.transform.position, Vector2.zero) < 25)
            enemy.transform.position = Random.insideUnitCircle * 30;

        enemy.GetComponent<SpriteRenderer>().sprite = badWords[Random.Range(0, badWords.Count)];

        rand = Random.Range(0.5f, 0.8f);

        enemy.GetComponent<SpriteRenderer>().color = new Color(rand, rand + 0.08f, rand + 0.13f);

        enemiesSpawned++;
        print("Enemies Spawned " + enemiesSpawned);
    }

}