using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PowerUpsController : MonoBehaviour
{
    [SerializeField] protected float speed;
    [SerializeField] private float xPositionDestroy = -13;
    [SerializeField] private float yMaxPosition = 3.6f;
    [SerializeField] private float yMinPosition = -4.2f;
    

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(transform.position.x, PositionY(), transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        isGameOver();
        Move();
        Destroy();
    }

    private void isGameOver()
    {
        if (GameManager.Instance.IsGameOver())
        {
            Destroy(gameObject);
        }
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
            Destroy(gameObject);
        }
    }  
}
