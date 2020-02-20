﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    CharacterController Char;
    public float speed;
    Vector3 MoveDir;
    Vector3 Velocity = Vector3.zero;
    public float gravity = 10.0f;
    public float jumpHeight = 10f;
    public float distToGround = 2f;
    public LayerMask ground;

    bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        Char = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, distToGround, ground);

        if (isGrounded && Velocity.y < 0)
        {
            Velocity.y = -2f;
        }

        MoveDir = transform.TransformDirection(transform.forward);
        Char.Move((MoveDir * speed) * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            Velocity.y = Mathf.Sqrt(jumpHeight * -2f * -(gravity));
        }

        Velocity.y -= gravity * Time.deltaTime;

        Char.Move(Velocity * Time.deltaTime);
    }

}
