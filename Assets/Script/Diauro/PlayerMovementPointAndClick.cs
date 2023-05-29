using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum PLAYER_STATES
{
    IDLE, RUNNING, RUNNING_TO_ATTACK, ATTACKING
}

public class PlayerMovementPointAndClick : MonoBehaviour
{
    public NavMeshAgent theAgent;
    public Animator anim;
    public PLAYER_STATES states;
    public Transform target;
    private void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                
                switch (hit.collider.tag)
                {
                    case "Ground":
                        theAgent.SetDestination(hit.point);
                        states = PLAYER_STATES.RUNNING;
                        break;
                    case "Enemy":
                        theAgent.SetDestination(hit.point);
                        states = PLAYER_STATES.RUNNING_TO_ATTACK;
                        target = hit.transform;
                        break;
                }
            }
        }

        if (theAgent.remainingDistance <= theAgent.stoppingDistance 
            && !theAgent.pathPending)
        {
            switch (states)
            {
                case PLAYER_STATES.RUNNING:
                    states = PLAYER_STATES.IDLE;
                    break;
                case PLAYER_STATES.RUNNING_TO_ATTACK:
                    states = PLAYER_STATES.ATTACKING;
                    break;
            }
        }
        if(states== PLAYER_STATES.ATTACKING)
        {
            Vector3 directionToTarget = target.position - transform.position;
            directionToTarget.y = 0; // This line ensures that the agent only rotates around the y-axis
            Quaternion rotation = Quaternion.LookRotation(directionToTarget);

            // Smoothly rotate the agent to this new rotation
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime*2);
        }


        anim.SetBool("Attack", states == PLAYER_STATES.ATTACKING);

        float vel = theAgent.velocity.magnitude / theAgent.speed;
        anim.SetFloat("Mov", vel );
    }
}
