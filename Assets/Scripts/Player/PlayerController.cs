using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerStateManager _playerStateManager;
    public PlayerMovementData data;
    PlayerInputManager _playerInput;
    public ButtonManager[] buttonManagers;


    private void Awake()
    {
        _playerInput = new PlayerInputManager(buttonManagers[0], buttonManagers[1], buttonManagers[2]);
        _playerStateManager = new PlayerStateManager();

    }
    private void OnEnable()
    {

    }


    private void Update()
    {
        _playerStateManager.CurrentState.OnUpdate();
        GroundCheck();

    }
    private void FixedUpdate()
    {
        _playerStateManager.CurrentState.OnFixedUpdate();

    }
    private void LateUpdate()
    {

    }


    private void GroundCheck()
    {
        Vector2 rayCastPosition = transform.position - new Vector3(0, -0.4f, 0);

        if (Physics2D.Raycast(rayCastPosition,Vector2.down,data.RayCastMaxDistance,data.GroundLayers))
        {
            Debug.DrawRay(rayCastPosition, Vector3.down * data.RayCastMaxDistance, Color.black);
            data.Grounded = true;
        }
        else data.Grounded = false;
    }



}


[System.Serializable]
public struct PlayerMovementData
{
    [Header("PlayerWalkingValue")]
    public float WalkingSpeed;
    [Header("Falling/Landing")]
    public bool Grounded;
    public float RayCastMaxDistance;
    public LayerMask GroundLayers;



}