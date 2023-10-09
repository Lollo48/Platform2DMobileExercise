using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator Animator;
    public SpriteRenderer SpriteRenderer;

    private void Awake()
    {
        Animator = GetComponent<Animator>();
        SpriteRenderer = GetComponent<SpriteRenderer>();
        
    }

    public void UpdateAnimatorValues(string AnimationName, bool isWalking)
    {
        Animator.SetBool(AnimationName, isWalking);

    }




    
}
