using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum PLAYER_STATES
{
    IDLE, RUNNING, RUNNING_TO_ATTACK, ATTACKING, DIE
}

public class States : MonoBehaviour
{
    public PLAYER_STATES states;
    
}
