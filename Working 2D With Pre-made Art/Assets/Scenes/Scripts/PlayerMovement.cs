using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;

    public PhysicsMaterial2D frictionMoving;
    public PhysicsMaterial2D plentyOfFriction;

    Vector2 movement;
    // Update is called once per frame
    private void Update()
    {
        rb.sharedMaterial = plentyOfFriction;
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        if ((movement.x > 0 || movement.x < -0) || (movement.y > 0 || movement.y < 0))
        {
            rb.sharedMaterial = frictionMoving;
        }

        if (movement.x > 0)
        {
            animator.SetFloat("idleLeftRight", 1);
            animator.SetFloat("idleFrontBack", 0);
        }
        if (movement.x < 0)
        {
            animator.SetFloat("idleLeftRight", -1);
            animator.SetFloat("idleFrontBack", 0);
        }
        if (movement.y > 0)
        {
            animator.SetFloat("idleFrontBack", 1);
            animator.SetFloat("idleLeftRight", 0);
        }
        if (movement.y < 0)
        {
            animator.SetFloat("idleFrontBack", -1);
            animator.SetFloat("idleLeftRight", 0);
        }

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    Vector2 lastReverseForce;
    int flag = 0;
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime); // Move rigidbody according to horizontal/vertical axes and moveSpeed
    }
}
