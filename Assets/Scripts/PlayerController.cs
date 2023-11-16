using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    Vector2 movementInput;
    public float moveSpeed = 1f;
    public float collisionOffset = 0.05f;
    public ContactFilter2D movementFilter;
    Rigidbody2D rb;
    List<RaycastHit2D> castCollisions = new List<RaycastHit2D>();
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update () 
    {
        animator.SetFloat("Horizontal", movementInput.x);
        animator.SetFloat("Vertical", movementInput.y);
        animator.SetFloat("Speed", movementInput.sqrMagnitude);
    }

    private void FixedUpdate () 
    {
        if (movementInput != Vector2.zero)
        {
            int count = rb.Cast
            (
                movementInput, // X and Y values between -1 and 1 that represent the direction from the body to look for collisions
                movementFilter, // The settings that determine where a collission can occur on such as layers to collide with
                castCollisions, // List of collissions to store the found collisison into after the Cast is finished
                moveSpeed * Time.fixedDeltaTime * collisionOffset // The Amount of ast equal to the movement plus an offset
            );

            if (count == 0) 
            {
                rb.MovePosition(rb.position + movementInput * moveSpeed * Time.fixedDeltaTime);
            }
        }
    }

    void OnMove (InputValue movementValue) 
    {
        movementInput = movementValue.Get<Vector2>();
    }
}
