using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    private Animator _animator;
    private float _horizontal;
    
    [SerializeField] private float movementSpeed;
    [SerializeField] private float jumpSpeed;

    private bool _ground;
    [SerializeField] private float rayDistance;
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Horizontal movement
        _horizontal = Input.GetAxisRaw("Horizontal");
        _animator.SetBool("running", _horizontal != 0.0f);
        if (_horizontal < 0.0f) transform.localScale = new Vector3(-0.2f, 0.2f, 0.2f);
        else if(_horizontal > 0.0f) transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);

        // Check if we're on the ground
        Debug.DrawRay(transform.position, Vector3.down * rayDistance, Color.cyan);
        _ground = Physics2D.Raycast(transform.position, Vector3.down, rayDistance);
        
        // Jump control
        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && _ground)
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

    private void OnBecameInvisible()
    {
        GameStats.Instance.SetLife(0.0f);
    }
    
}
