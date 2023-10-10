using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkRightState : State<PlayerState>
{
    PlayerController _playerController;
    PlayerStateManager _playerStateManager;
    public WalkRightState(PlayerState stateID, StatesMachine<PlayerState> stateMachine = null) : base(stateID, stateMachine)
    {
        _playerStateManager = (PlayerStateManager)m_stateMachine;

    }


    public override void OnEnter()
    {
        base.OnEnter();
        if (_playerController == null) _playerController = _playerStateManager._playerController;
        _playerController.AnimationController.UpdateAnimatorValues("IsWalking", true);
        _playerController.AnimationController.SpriteRenderer.flipX = true;
    }
       

    public override void OnUpdate()
    {
        base.OnUpdate();
        #region CHANGE STATE
        if (!_playerStateManager._playerController._playerInput.RightButton.isPressed)
            _playerStateManager.ChangeState(PlayerState.Idle);
        #endregion

    }

    public override void OnFixedUpdate()
    {
        base.OnFixedUpdate();
        HandleMovement();
    }


    public override void OnExit()
    {
        base.OnExit();
        _playerController.PlayerRigidBody2D.velocity = Vector2.zero;
    }


    private void HandleMovement()
    {
        float speed = _playerController.data.WalkingSpeed;
        _playerController.PlayerRigidBody2D.velocity = new Vector2(speed, _playerController.PlayerRigidBody2D.velocity.y);
    }


}
