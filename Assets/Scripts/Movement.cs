using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float playerMoveSpeed = 5;
    [SerializeField] float dashFactor = 3;
    [SerializeField] Vector3 jumpForce = new(0, 10, 0);

    Vector3 move;
    Rigidbody rb;
    bool jump = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        move = new Vector3(x, 0, z) * playerMoveSpeed;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            move *= dashFactor;
        }
            
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            jump = true;
        }
    }

    private void FixedUpdate()
    {
        move.y = rb.velocity.y;
        rb.velocity = transform.TransformDirection(move);

        if (jump)
        {
            rb.AddForce(jumpForce, ForceMode.Impulse);
            jump = false;
        }
    }

    bool IsGrounded()
    {
        Ray ray = new Ray(transform.position, -transform.up);

        if (Physics.Raycast(ray, 1.01f))
            return true;
        else
            return false;
    }

}
