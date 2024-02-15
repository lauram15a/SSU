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
            yield return new WaitForSeconds(4);
            textNewLevel.gameObject.SetActive(false);

            if (i == 0)
            {
                numEnemies = 5;

                for (int j = 0; j < numEnemies; j++)
                {
                    Instantiate(enemyPrefab, transform.position, Quaternion.identity);
                    
                    if (j == (numEnemies - 1))
                    {
                        yield return new WaitForSeconds(5);
                    }
                    else
                    {
                        yield return new WaitForSeconds(2.5f);
                    }
                }
            }
            else if (i == 1)
            {
                numEnemies = 5;

                for (int j = 0; j < numEnemies; j++)
                {
                    Instantiate(enemyPrefab, transform.position, Quaternion.identity);

                    if (j == (numEnemies - 1))
                    {
                        yield return new WaitForSeconds(5);
                    }
                    else
                    {
                        yield return new WaitForSeconds(Random.Range(1, 4));
                    }
                }
            }
            else if (i == 2)
            {
                numEnemies = 10;

                for (int j = 0; j < numEnemies; j++)
                {
                    Instantiate(enemyPrefab, transform.position, Quaternion.identity);

                    if (j == (numEnemies - 1))
                    {
                        yield return new WaitForSeconds(5);
                    }
                    else
                    {
                        yield return new WaitForSeconds(Random.Range(1, 2));
                    }
                }
            }
            else if (i == 3)
            {
                numEnemies = 15;

                for (int j = 0; j < numEnemies; j++)
                {
                    Instantiate(enemyPrefab, transform.position, Quaternion.identity);

                    if (j == (numEnemies - 1))
                    {
                        yield return new WaitForSeconds(5);
                    }
                    else
                    {
                        yield return new WaitForSeconds(Random.Range(2, 4));
                    }
                }
            }
            else if (i == 4)
            {
                numEnemies = 20;

                for (int j = 0; j < numEnemies; j++)
                {
                    Instantiate(enemyPrefab, transform.position, Quaternion.identity);

                    if (j == (numEnemies - 1))
                    {
                        yield return new WaitForSeconds(5);
                    }
                    else
                    {
                        yield return new WaitForSeconds(Random.Range(1, 4));
                    }
                }
            }
        }
    }
}
