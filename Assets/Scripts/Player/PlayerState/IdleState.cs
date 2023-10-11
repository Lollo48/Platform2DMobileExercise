using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : State<PlayerState>
{
    PlayerController _playerController;
    PlayerStateManager _playerStateManager;

    public IdleState(PlayerState playerState, StatesMachine<PlayerState> stateManager = null) : base(playerState, stateManager)
    {
        _playerStateManager = (PlayerStateManager)m_stateMachine;
        
    }


    public override void OnEnter()
    {
        base.OnEnter();
        _playerController = _playerStateManager._playerController;
        if (_playerController == null) return;
        else
        {
            _playerController.AnimationController.UpdateAnimatorValues("IsWalking", false);
            _playerController.PlayerRigidBody2D.velocity = Vector2.zero;
        }


    }


    public override void OnUpdate()
    {
        base.OnUpdate();
        #region CHANGE STATE
        if (_playerStateManager._playerController._playerInput.RightButton.isPressed && _playerStateManager._playerController.data.Grounded)
            _playerStateManager.ChangeState(PlayerState.WalkRight);
        if (_playerStateManager._playerController._playerInput.LeftButton.isPressed && _playerStateManager._playerController.data.Grounded)
            _playerStateManager.ChangeState(PlayerState.WalkLeft);
        if(_playerStateManager._playerController.data.CanJump && _playerStateManager._playerController.data.Grounded)
        {
            _playerStateManager._playerController.moveDirection = Vector2.zero;
            _playerStateManager.ChangeState(PlayerState.Jump);
        }
        #endregion





    }




    public override void OnExit()
    {
        base.OnExit();
        
    }

}