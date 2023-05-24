using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyPatrol : MonoBehaviour
{
    public float speed = 10;
    public bool MoveRight;
    private Animator anim;
    


    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (MoveRight)
        {
            anim.SetBool("isRunning", true);
            transform.Translate(2 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(5, 5);
        }
        else
        {
            anim.SetBool("isRunning", true);
            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(-5, 5);
        }
    }


    void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.CompareTag("turn"))
        {
            if (MoveRight)
            {
                MoveRight = false;
            }
            else
            {
                MoveRight = true;
            }
        }
    }
}
