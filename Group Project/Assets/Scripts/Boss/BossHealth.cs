using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public int health = 10;

    Animator myAnimation;

    void Update()
    {
        if (health <= 0)
        {
            myAnimation.SetBool("die", true);
            
        }
    }
}
