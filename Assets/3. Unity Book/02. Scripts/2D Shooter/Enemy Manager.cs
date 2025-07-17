using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : Singleton<EnemyManager>
{
    public int poolSize = 10;

    //public List<GameObject> enemyObjectPool;
    public Queue<GameObject> enemyObjectPool;
    public Transform[] spawnPoints;

    public GameObject enemyFactory;

    public float currentTime;
    private float minTime = 1;
    private float maxTime = 5;
    public float createTime = 1f;


    private void Start()
    {
        createTime = Random.Range(minTime, maxTime);

        //enemyObjectPool = new List<GameObject>();
        enemyObjectPool = new Queue<GameObject>();

        for (int i = 0; i < poolSize; i++)
        {
            GameObject enemy = Instantiate(enemyFactory);

            enemyObjectPool.Enqueue(enemy);
            //enemyObjectPool[i] = enemy;
            enemy.SetActive(false);
        }
    }

    private void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime > createTime)
        {
            //큐
            if (enemyObjectPool.Count > 0)
            {
                currentTime = 0f;
                createTime = Random.Range(minTime, maxTime);

                GameObject enemy = enemyObjectPool.Dequeue();

                int ranIndex = Random.Range(0, spawnPoints.Length);
                enemy.transform.position = spawnPoints[ranIndex].position;
                enemy.SetActive(true);
            }

            //리스트
            //if (enemyObjectPool.Count > 0)
            //{
            //    currentTime = 0f;
            //    createTime = Random.Range(minTime, maxTime);

            //    GameObject enemy = enemyObjectPool[0];

            //    int ranIndex = Random.Range(0, spawnPoints.Length);
            //    enemy.transform.position = spawnPoints[ranIndex].position;
            //    enemy.SetActive(true);
            //}
            //currentTime = 0;
            //createTime = Random.Range(minTime, maxTime);

            //for (int i = 0; i < poolSize; i++)
            //{
            //    GameObject enemy = enemyObjectPool[i];
            //    if (!enemy.activeSelf)
            //    {
            //        int ranIndex = Random.Range(0, spawnPoints.Length);
            //        Transform spawnPoint = spawnPoints[ranIndex];

            //        enemy.transform.position = transform.position;
            //        enemy.SetActive(true);

            //        break;
            //    }
            //}
        }
    }
}
