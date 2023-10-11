using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public abstract class BulletBase : MonoBehaviour
{
    protected Rigidbody2D m_rigidbody2D;


    protected virtual void Awake()
    {
        m_rigidbody2D = GetComponent<Rigidbody2D>();
    }

    protected virtual void FixedUpdate() 
    {
        HandleMovement();
    }

    protected virtual void OnDisableGameObject(bool disable) => gameObject.SetActive(disable);

    protected virtual void HandleMovement() { }

    protected virtual void CollisionEnter(Collision2D collision2D) { } 

    private void OnCollisionEnter2D(Collision2D collision) => CollisionEnter(collision);



}
