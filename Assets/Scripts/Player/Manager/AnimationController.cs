using UnityEngine;

public class AnimationController : MonoBehaviour
{

    Animator _animator;
    [HideInInspector]
    public SpriteRenderer SpriteRenderer;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        SpriteRenderer = GetComponent<SpriteRenderer>();
        
    }

    public void UpdateAnimatorValues(string AnimationName, bool isWalking)
    {
        _animator.SetBool(AnimationName, isWalking);

    }




    
}
