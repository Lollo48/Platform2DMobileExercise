using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    [Header("Player State Manager")]
    public PlayerStateManager _playerStateManager;

    [Header("Player Stats")]
    PlayerStats _PlayerStats;
    
    [Header("Player input and Player locomotion")]
    [HideInInspector]
    public PlayerInputManager _playerInput;
    public ButtonManager[] buttonManagers;
    [HideInInspector]
    public Rigidbody2D PlayerRigidBody2D;
    public PlayerMovementData data;
    [HideInInspector]
    public Vector2 moveDirection;


    [Header("Player Animation")]
    [HideInInspector]
    public AnimationController AnimationController;

    [Header("Player UI Manager")]
    public PlayerUIManager PlayerUIManager;
    Slider _slider;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI Ammo;


    private void Awake()
    {
        _playerInput = new PlayerInputManager(buttonManagers[0], buttonManagers[1]);
        _playerStateManager = new PlayerStateManager(this);
        _PlayerStats = new PlayerStats(this);
        _slider = GetComponentInChildren<Slider>();
        //_scoreText = GetComponentInChildren<TextMeshProUGUI>();
        PlayerUIManager = new PlayerUIManager(_slider,data.MaxHP,ScoreText,Ammo,this);

    }

    private void Start()
    {
        PlayerRigidBody2D = GetComponent<Rigidbody2D>();
        AnimationController = GetComponentInChildren<AnimationController>();
        data.Ammo = data.InitialAmmo;
        Ammo.text = data.InitialAmmo.ToString();
    }

    private void Update()
    {
        //Debug.Log(data.CanJump);
        _playerStateManager.CurrentState.OnUpdate();
        GroundCheck();

    }
    private void FixedUpdate()
    {
        _playerStateManager.CurrentState.OnFixedUpdate();

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


    public void CanJump()
    {
        data.CanJump = true;
    }



}


[System.Serializable]
public struct PlayerMovementData
{
    [Header("Stats")]
    public float MaxHP;
    public float HP;
    public float RestoreHP;
    public float CollectibleDamage;
    [Header("PlayerWalkingValue")]
    public float WalkingSpeed;
    [Header("Falling/Landing")]
    public bool Grounded;
    public float RayCastMaxDistance;
    public LayerMask GroundLayers;
    public bool CanJump;
    public bool IsFinished;
    public float JumpHeight;
    [Header("ScorePoints")]
    public float ScorePoints;
    public float ScorePickUp;
    [Header("Weapon")]
    public int InitialAmmo;
    public int Ammo;

}