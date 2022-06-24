using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    private GameObject _player;
    [SerializeField] private float movementSpeed;
    [SerializeField] private float distanceToFollow;
    [SerializeField] private float lifeTime;

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
        if (_player == null) return;
        if (lifeTime <= 0.0f) Destroy(gameObject);

        lifeTime -= Time.deltaTime;
        if (Math.Abs(_player.transform.position.x - transform.position.x) > 0.5f)
        {
            _right = _player.transform.position.x >= transform.position.x;
            _distance = Math.Abs(_player.transform.position.x - transform.position.x);
        }
    }

    private void FixedUpdate()
    {
        if (_distance <= distanceToFollow)
        {
            // Debug.Log("Following...");
            _rigidbody2D.velocity = new Vector2((_right ? 1 : -1) * movementSpeed, _rigidbody2D.velocity.y);
            var transformLocalScale = transform.localScale;
            if (_right && transform.localScale.x > 0)
            {
                //Debug.Log("Pa la derecha (* -1)");
                transformLocalScale.x *= -1;
                transform.localScale = transformLocalScale;
            }

            if (!_right && transform.localScale.x < 0)
            {
                //Debug.Log("Pa la izquierda (* -1)");
                transformLocalScale.x *= -1;
                transform.localScale = transformLocalScale;
            }
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameStats.Instance.ApplyDamage(0.5f);
        }
    }
}
