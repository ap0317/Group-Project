using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    public int health = 3;
    

    

    void Start()
    {
        
    }

    void Update()
    {
        if (health <= 0)
        {

            Destroy(gameObject);
            
        }
    }
}
