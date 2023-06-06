using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public States state;
    public Image bar;

    public void TakeDamage(float damage)
    {
        health-= damage;
        if(health <= 0)
        {
            Die();
        }
    }

    private void Update()
    {
        bar.fillAmount = health / maxHealth;
    }

    private void Die()
    {
        state.states = PLAYER_STATES.DIE;
    }
}
