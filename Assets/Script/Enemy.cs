using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public States enemyState;
    public Animator anim;
    public Transform target;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            target = other.transform;
            enemyState.states = PLAYER_STATES.ATTACKING;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            target = null;
            enemyState.states = PLAYER_STATES.IDLE;
        }
    }

    private void Update()
    {
        anim.SetBool("Attack", enemyState.states == PLAYER_STATES.ATTACKING);
        anim.SetBool("Die", enemyState.states == PLAYER_STATES.DIE);
        if( enemyState.states== PLAYER_STATES.ATTACKING)
        {
            Vector3 directionToTarget = target.position - transform.position;
            directionToTarget.y = 0; // This line ensures that the agent only rotates around the y-axis
            Quaternion rotation = Quaternion.LookRotation(directionToTarget);

            // Smoothly rotate the agent to this new rotation
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime*2);
        }
    }
}
