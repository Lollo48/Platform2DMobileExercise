using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallState : State<PlayerState>
{
    PlayerController _playerController;
    PlayerStateManager _playerStateManager;
    public FallState(PlayerState playerState, StatesMachine<PlayerState> stateManager = null) : base(playerState, stateManager)
    {
        _playerStateManager = (PlayerStateManager)m_stateMachine;
    }


    public override void OnEnter()
    {
        base.OnEnter();
        if (_playerController == null) _playerController = _playerStateManager._playerController;
        _playerController.AnimationController.UpdateAnimatorValues("IsFalling", true);
    }


    public override void OnUpdate()
    {
        base.OnUpdate();
        if (_playerController.data.Grounded)
            _playerStateManager.ChangeState(PlayerState.Idle);

    }

    public override void OnFixedUpdate()
    {
        base.OnFixedUpdate();

    }


    public override void OnExit()
    {
        base.OnExit();
        _playerController.AnimationController.UpdateAnimatorValues("IsFalling", false);
    }

  
    

}