using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PickUpSystem : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PickUp(collision);
    }

    /// <summary>
    /// method that implement the ability to take object 
    /// </summary>
    protected abstract void PickUp(Collider2D collider);

}
