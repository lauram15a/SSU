using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;

    [SerializeField] private GameObject pwu_AddPointsPrefab;
    [SerializeField] private GameObject pwu_SubPointsPrefab;
    [SerializeField] private GameObject pwu_KillerPrefab;
    [SerializeField] private GameObject pwu_RefillPrefab;
    [SerializeField] private GameObject pwu_LivesPrefab;

    [SerializeField] private int numEnemies;
    [SerializeField] private int numPowerUps;
    [SerializeField] private TextMeshProUGUI textLevel;
    [SerializeField] private TextMeshProUGUI textNewLevel;
    private int numLevels = 5;

    private GameObject[] powerUpsList = new GameObject[5];

    // Start is called before the first frame update
    void Start()
    {
        powerUpsList = new GameObject[] { pwu_AddPointsPrefab, pwu_SubPointsPrefab, pwu_KillerPrefab, pwu_RefillPrefab, pwu_LivesPrefab };
        StartCoroutine(Spawner());
    }

    IEnumerator Spawner()
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

                    if (IntRandom(1, 2)  == 1)
                    {
                        Instantiate(powerUpsList[IntRandom(0, 4)], transform.position, Quaternion.identity);
                    }
                    
                    if (j == (numEnemies - 1))
                    {
                        yield return new WaitForSeconds(5);
                    }
                    else
                    {
                        yield return new WaitForSeconds(1);
                    }
                }
            }
            else if (i == 1)
            {
                numEnemies = 10;

                for (int j = 0; j < numEnemies; j++)
                {
                    Instantiate(enemyPrefab, transform.position, Quaternion.identity);

                    if (IntRandom(1, 2) == 1)
                    {
                        Instantiate(powerUpsList[IntRandom(0, 4)], transform.position, Quaternion.identity);
                    }

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
                numEnemies = 15;
                numPowerUps = 2;

                for (int j = 0; j < numEnemies; j++)
                {
                    Instantiate(enemyPrefab, transform.position, Quaternion.identity);

                    for (int k = 0; k < numPowerUps; k++)
                    {
                        if (IntRandom(1, 2) == 1)
                        {
                            Instantiate(powerUpsList[IntRandom(0, 4)], transform.position, Quaternion.identity);
                        }
                    }
                    
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
                numEnemies = 20;

                for (int j = 0; j < numEnemies; j++)
                {
                    Instantiate(enemyPrefab, transform.position, Quaternion.identity);
                    Instantiate(powerUpsList[IntRandom(0, 4)], transform.position, Quaternion.identity);                  

                    if (j == (numEnemies - 1))
                    {
                        yield return new WaitForSeconds(5);
                    }
                    else
                    {
                        yield return new WaitForSeconds(Random.Range(0.5f, 2));
                    }
                }
            }
            else if (i == 4)
            {
                numEnemies = 25;
                numPowerUps = 2;

                for (int j = 0; j < numEnemies; j++)
                {
                    Instantiate(enemyPrefab, transform.position, Quaternion.identity);

                    for (int k = 0; k < numPowerUps; k++)
                    {
                        if (IntRandom(1, 2) == 1)
                        {
                            Instantiate(powerUpsList[IntRandom(0, 4)], transform.position, Quaternion.identity);
                        }
                    }

                    if (j == (numEnemies - 1))
                    {
                        yield return new WaitForSeconds(5);
                    }
                    else
                    {
                        yield return new WaitForSeconds(Random.Range(0.5f, 1.5f));
                    }
                }
            }
        }

        GameManager.Instance.GameOver(true);
    }


    private int IntRandom(int numMin, int numMax)
    {
        int random = UnityEngine.Random.Range(numMin, (numMax + 1));
        return random;
    }
}
