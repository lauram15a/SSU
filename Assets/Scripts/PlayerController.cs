using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        float inputH = Input.GetAxisRaw("Horizontal");
        float inputV = Input.GetAxisRaw("Vertical");
        transform.Translate(new Vector3(inputH, inputV, 0).normalized * speed * Time.deltaTime);

        DelimitedMovement();
    }

    private void DelimitedMovement()
    {
        float xClamped = Mathf.Clamp(transform.position.x, -9.72f, 9.72f);
        float yClamped = Mathf.Clamp(transform.position.y, -4.19f, 4.19f);
        transform.position = new Vector3(xClamped, yClamped, 0);
    }
}
