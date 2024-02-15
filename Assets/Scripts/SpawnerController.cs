using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private int numEnemies;
    [SerializeField] private TextMeshProUGUI textLevel;
    [SerializeField] private TextMeshProUGUI textNewLevel;
    private int numLevels = 5;

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
        for (int i = 0; i < numLevels; i++)
        {
            textLevel.text = "Level: " + (i + 1);

            textNewLevel.gameObject.SetActive(true);
            textNewLevel.text = "Level  " + (i + 1);
            yield return new WaitForSeconds(5);
            textNewLevel.gameObject.SetActive(false);

            if (i == 0)
            {
                for (int j = 0; j < numEnemies; j++)
                {
                    Instantiate(enemyPrefab, transform.position, Quaternion.identity);
                    yield return new WaitForSeconds(Random.Range(1, 4));
                }
            }
            else if (i == 1)
            {
                for (int j = 0; j < numEnemies; j++)
                {
                    Instantiate(enemyPrefab, transform.position, Quaternion.identity);
                    yield return new WaitForSeconds(Random.Range(1, 4));
                }
            }
            else if (i == 2)
            {
                for (int j = 0; j < numEnemies; j++)
                {
                    Instantiate(enemyPrefab, transform.position, Quaternion.identity);
                    yield return new WaitForSeconds(Random.Range(1, 4));
                }
            }
            else if (i == 3)
            {
                for (int j = 0; j < numEnemies; j++)
                {
                    Instantiate(enemyPrefab, transform.position, Quaternion.identity);
                    yield return new WaitForSeconds(Random.Range(1, 4));
                }
            }
            else if (i == 4)
            {
                for (int j = 0; j < numEnemies; j++)
                {
                    Instantiate(enemyPrefab, transform.position, Quaternion.identity);
                    yield return new WaitForSeconds(Random.Range(1, 4));
                }
            }
        }
    }
}
