using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;
    
    // Update is called once per frame
    // Will handle all input
    void Update ()
    {
        movement.x = Input.GetAxisRaw("Horizontal"); // Provides a value between -1 and 1 (Left = -1, Right = 1)
        movement.y = Input.GetAxisRaw("Vertical"); // Provides a value between -1 and 1 (Down = -1, Up = 1)

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    // Handle all movement
    void FixedUpdate () 
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
