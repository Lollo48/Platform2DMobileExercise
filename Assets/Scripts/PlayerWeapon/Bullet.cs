using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class Bullet : BulletBase
{
  
    [SerializeField] private float m_bulletspeed;
    

    protected override void HandleMovement()
    {
        Vector2 moveDirection = Vector2.up * m_bulletspeed;
        m_rigidbody2D.velocity = moveDirection;

    }

  
    protected override void CollisionEnter(Collision2D collision2D)
    {
        base.CollisionEnter(collision2D);
        this.gameObject.SetActive(false);



    }

 

  

}


