using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private Health targetHealth;
    public string tagTarget = "Enemy";
    public float damage = 10;

    public States states;
    //public PlayerMovementPointAndClick pMov;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag(tagTarget))
        {
            targetHealth = other.GetComponent<Health>();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(tagTarget))
        {
            targetHealth = null;
        }
    }
    public void AttackMelee()
    {     
        targetHealth.TakeDamage(damage);
        if(targetHealth.health< 0)
        {
            targetHealth = null;
            states.states = PLAYER_STATES.IDLE;
        }
    }
    
}
