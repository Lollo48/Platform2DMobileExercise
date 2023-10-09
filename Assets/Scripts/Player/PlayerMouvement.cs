using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerMouvement : MonoBehaviour
{
    Rigidbody2D m_playerRigidBody;
    Vector2 m_moveDirection;
    public float movementSpeed;




    private void Awake()
    {
        m_playerRigidBody = GetComponent<Rigidbody2D>();
    }

    

    public void isStationaryRight()
    {
        m_moveDirection = Vector2.right * movementSpeed * Time.deltaTime;
        m_moveDirection.Normalize();
        m_moveDirection.y = 0;
        m_playerRigidBody.velocity = m_moveDirection;
    }

    public void isStationaryLeft()
    {
        m_moveDirection = Vector2.left * movementSpeed * Time.deltaTime;
        m_moveDirection.Normalize();
        m_moveDirection.y = 0;
        m_playerRigidBody.velocity = m_moveDirection;
    }

}

