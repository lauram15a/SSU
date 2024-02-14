using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float xPositionDestroy;
    [SerializeField] private float yMaxPosition;
    [SerializeField] private float yMinPosition;
    [SerializeField] private GameObject missilePrefab;
    [SerializeField] private GameObject spawnPoint;
    private bool isAlive = true;
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MissileSpawner());
        transform.position = new Vector3(transform.position.x, PositionY(), transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Destroy();
    }

    private float PositionY()
    {
        float y = UnityEngine.Random.Range(yMinPosition, yMaxPosition);
        return y;
    }

    private void Move()
    {
        transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
    }

    private void Destroy()
    {
        if (transform.position.x <= xPositionDestroy)
        {
            isAlive = false;
            Destroy(gameObject);
        }

    }

    IEnumerator MissileSpawner()
    {
        while (isAlive)
        {
            Instantiate(missilePrefab, spawnPoint.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
        }
    }
}
