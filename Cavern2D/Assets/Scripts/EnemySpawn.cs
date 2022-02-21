using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject EnemyPrefab;

    [SerializeField]
    private float EnemyInterval = 2f;


    // Start is called before the first frame update

    // Coroutine method makes the game wait specific time before running it again.

    void Start()
    {
        StartCoroutine(SpawnEnemy(EnemyInterval, EnemyPrefab));
    }

    private IEnumerator SpawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(50f, 300f), Random.Range(50, 75f), 0), Quaternion.identity);
   
    }
}
