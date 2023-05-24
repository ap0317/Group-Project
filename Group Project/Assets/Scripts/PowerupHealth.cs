using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupHealth : MonoBehaviour
{
    public int muliplier = 1;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup(other);
        }
    }

    void Pickup(Collider2D player)
    {

        PlayerManager health = player.GetComponent<PlayerManager>();
        health.playerHealth += muliplier;



        Destroy(gameObject);
    }
}
