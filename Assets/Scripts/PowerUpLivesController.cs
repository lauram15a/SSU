using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivePowerUpController : PowerUpsController
{
    [SerializeField] private bool isRefillLives;
    [SerializeField] private bool isLives;
    [SerializeField] private bool isKiller;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("MissilePlayer"))
        {
            if (isRefillLives)
            {
                GameManager.Instance.RefillPlayerLives();
            }
            else if (isLives)
            {
                int random = Random.Range(1, 3); 

                if (random == 1)
                {
                    GameManager.Instance.AddPlayerLives();
                }
                else
                {
                    GameManager.Instance.SubPlayerLives();       
                }
            }
            else if (isKiller)
            {
                GameManager.Instance.KillPlayer();
            }

            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
