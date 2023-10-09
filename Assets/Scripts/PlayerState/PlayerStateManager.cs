using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateManager : StatesMachine<PlayerState>
{
    

    public PlayerStateManager( Dictionary<PlayerState, State<PlayerState>> listOfSTtes = null, State<PlayerState> currentState = null, State<PlayerState> nextState = null) : base(listOfSTtes, currentState, nextState)
    {
        
    }



    protected override void InitStates()
    {
        AllStates.Add(PlayerState.Idle, new IdleState(PlayerState.Idle, this));
        AllStates.Add(PlayerState.Walk, new WalkState(PlayerState.Idle, this));

        CurrentState = AllStates[PlayerState.Idle];
        CurrentState.OnEnter();
    }


}



public enum PlayerState
{
    Idle,
    Walk
 

}