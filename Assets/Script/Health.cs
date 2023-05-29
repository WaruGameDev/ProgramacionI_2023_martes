using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health;
    public float maxHealth;

    public void TakeDamage(float damage)
    {
        health-= damage;
        if(health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
       Destroy(gameObject);
    }
}