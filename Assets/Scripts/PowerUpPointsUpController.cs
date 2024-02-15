using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpPointsUpController : PowerUpsController
{
    [SerializeField] private bool isAddPoints;
    [SerializeField] private bool isSubPoints;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("MissilePlayer"))
        {
            if (isAddPoints)
            {
                GameManager.Instance.AddPoint(5);
            }
            else if (isSubPoints)
            {
                GameManager.Instance.SubPoint(5);
            }
            
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
