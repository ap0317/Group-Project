using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject attackPoint;
    public float radius;
    public LayerMask enemies;


    Animator myAnimation;

    // Start is called before the first frame update
    void Start()
    {
        myAnimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
    }

    void Attack()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            myAnimation.SetBool("attack", true);
        }
        if (Input.GetButtonUp("Fire1"))
        {
            myAnimation.SetBool("attack", false);
        }
    }

    void WeaponDamage()
    {
        Collider2D[] enemy = Physics2D.OverlapCircleAll(attackPoint.transform.position, radius, enemies);

        foreach 
    }
}
