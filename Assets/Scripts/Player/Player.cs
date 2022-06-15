using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    private float _horizontal;
    [SerializeField] private float movementSpeed;
    [SerializeField] private float jumpSpeed;
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _horizontal = Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            Jump();
        }
    }

    private void FixedUpdate()
    {
        _rigidbody2D.velocity = new Vector2(_horizontal * movementSpeed, _rigidbody2D.velocity.y);
    }

    private void Jump()
    {
        _rigidbody2D.AddForce(Vector2.up * jumpSpeed);
    }
}
