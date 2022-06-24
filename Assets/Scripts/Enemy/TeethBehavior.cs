using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeethBehavior : MonoBehaviour
{
    [SerializeField] private float lifeTime;

    void Update()
    {
        if(lifeTime <= 0.0f) Destroy(gameObject);

        lifeTime -= Time.deltaTime;
    }

    private void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            GameStats.Instance.ApplyDamage(0.5f);
        }
    }
}
