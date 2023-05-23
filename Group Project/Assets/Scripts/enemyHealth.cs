using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    public int health = 3;
    private Animator anim;

    

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (health <= 0)
        {
            
            anim.SetBool("dead", true);
            
        }
    }
}
