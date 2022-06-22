using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    private GameObject _player;
    [SerializeField] private float movementSpeed;
    [SerializeField] private float distanceToFollow;

    private bool _right;
    private float _distance;

    private Rigidbody2D _rigidbody2D;
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        _right = _player.transform.position.x >= transform.position.x;
        _distance = Math.Abs(_player.transform.position.x - transform.position.x);
    }

    private void FixedUpdate()
    {
        if (_distance <= distanceToFollow)
        {
            // Debug.Log("Following...");
            _rigidbody2D.velocity = new Vector2((_right ? 1 : -1) * movementSpeed, _rigidbody2D.velocity.y);
        }
    }
}
