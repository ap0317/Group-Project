using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;

    private Rigidbody2D rb;
    private bool facingRight = true;
    private float moveDirection;

    //update method called every signle frame, awake is called after all objects are initialized
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get Inputs
        moveDirection = Input.GetAxis("Horizontal"); // scale of -1 to 1
        //move
        rb.velocity = new Vector2((moveDirection) * moveSpeed, rb.velocity.y);
    }
}
