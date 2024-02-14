using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private int numEnemies;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemiesSpawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator EnemiesSpawner()
    {
        for (int i = 0; i < numEnemies; i++)
        {
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(1, 4));
        }
    }
}
