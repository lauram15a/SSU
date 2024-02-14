using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float xPositionDestroy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Destroy();
    }

    private void Move()
    {
        transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime);
    }

    private void Destroy()
    {
        if (transform.position.x >= xPositionDestroy)
        {
            Destroy(gameObject);
        }

    }
}
