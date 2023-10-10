using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateManager : StatesMachine<PlayerState>
{
    public PlayerController _playerController;

    public PlayerStateManager(PlayerController playerController, Dictionary<PlayerState, State<PlayerState>> listOfSTtes = null, State<PlayerState> currentState = null, State<PlayerState> nextState = null) : base(listOfSTtes, currentState, nextState)
    {
        _playerController = playerController;
    }



    protected override void InitStates()
    {
        AllStates.Add(PlayerState.Idle, new IdleState(PlayerState.Idle, this));
        AllStates.Add(PlayerState.WalkLeft, new WalkLeftState(PlayerState.WalkLeft, this));
        AllStates.Add(PlayerState.WalkRight, new WalkRightState(PlayerState.WalkRight, this));


        CurrentState = AllStates[PlayerState.Idle];
        CurrentState.OnEnter();
    }


}



public enum PlayerState
{
    Idle,
    WalkLeft,
    WalkRight,

 

}