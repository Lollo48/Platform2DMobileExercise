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
        if (_playerController == null) _playerController = _playerStateManager._playerController;
        _playerController.AnimationController.UpdateAnimatorValues("IsJumping", true);
        HandleJumping();
    }


    public override void OnUpdate()
    {
        base.OnUpdate();
        if(_playerController.data.IsFinished)
            _playerStateManager.ChangeState(PlayerState.Fall);

    }

    public override void OnFixedUpdate()
    {
        base.OnFixedUpdate();
        
    }


    public override void OnExit()
    {
        base.OnExit();
        _playerController.data.CanJump = false;
        _playerController.data.IsFinished = false;
        _playerController.AnimationController.UpdateAnimatorValues("IsJumping", false);
    }


    public void HandleJumping()
    {
        float jumpForce = Mathf.Sqrt(_playerController.data.JumpHeight * 2  * -Physics2D.gravity.y);
        Vector2 playerVelocity = _playerController.moveDirection;
        playerVelocity.y = jumpForce;
        _playerController.PlayerRigidBody2D.velocity = playerVelocity;


    }


}