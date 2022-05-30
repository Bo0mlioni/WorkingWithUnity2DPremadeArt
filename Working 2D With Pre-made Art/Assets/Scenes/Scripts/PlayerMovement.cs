using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;

    public PhysicsMaterial2D frictionMoving;
    public PhysicsMaterial2D plentyOfFriction;

    Vector2 movement;
    // Update is called once per frame
    private void Update()
    {
        rb.sharedMaterial = plentyOfFriction;
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        if ((movement.x == 1 || movement.x == -1) || (movement.y == 1 || movement.y == -1))
        {
            rb.sharedMaterial = frictionMoving;
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
