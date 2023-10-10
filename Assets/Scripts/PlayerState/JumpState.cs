using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpState : State<PlayerState>
{
    PlayerController _playerController;
    PlayerStateManager _playerStateManager;
    public JumpState(PlayerState playerState, StatesMachine<PlayerState> stateManager = null) : base(playerState, stateManager)
    {
        _playerStateManager = (PlayerStateManager)m_stateMachine;
    }


    public override void OnEnter()
    {
        base.OnEnter();

    }


    public override void OnUpdate()
    {
        base.OnUpdate();

        
    }

    public override void OnFixedUpdate()
    {
        base.OnFixedUpdate();
        
    }


    public override void OnExit()
    {
        base.OnExit();
      
    }



   

}