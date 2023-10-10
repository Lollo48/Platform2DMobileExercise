using UnityEngine;

public class AnimationController : MonoBehaviour
{

    Animator _animator;
    [HideInInspector]
    public SpriteRenderer SpriteRenderer;
    PlayerController _playerController;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        SpriteRenderer = GetComponent<SpriteRenderer>();
        _playerController = GetComponentInParent<PlayerController>();

        
    }

    private void OnEnable()
    {
        ActionManager.OnHitUpdate += UpdateHitAnimation;
    }


    private void OnDisable()
    {
        ActionManager.OnHitUpdate -= UpdateHitAnimation;
    }
    public void UpdateAnimatorValues(string AnimationName, bool isWalking)
    {
        _animator.SetBool(AnimationName, isWalking);

    }

    public void CanFall()
    {
        _playerController.data.IsFinished = true;
    }

    private void UpdateHitAnimation(float animation)
    {
        _animator.SetTrigger("IsHit");
    }
    
}
