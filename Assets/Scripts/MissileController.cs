using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float xPositionDestroy;
    [SerializeField] private int xDirection;

    private void Awake()
    {
        //transform.eulerAngles = new Vector3(0, 0, -90);
    }

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
        transform.Translate(new Vector3(xDirection, 0, 0) * speed * Time.deltaTime);
    }

    private void Destroy()
    {
        if (transform.position.x >= xPositionDestroy)
        {
            Destroy(gameObject);
        }
        
    }
}
