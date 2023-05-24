using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpeed : MonoBehaviour
{
    public float muliplier = 1.4f;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Pickup(other);
        }
    }

    void Pickup(Collider2D player)
    {

        PlayerMovement speed = player.GetComponent<PlayerMovement>();
        speed.moveSpeed *= muliplier;



        Destroy(gameObject);
    }
}
