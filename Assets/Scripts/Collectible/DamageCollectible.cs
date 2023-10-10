using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCollectible : PickUpSystem
{
	protected override void PickUp(Collider2D collider)
	{
		if (collider.gameObject.TryGetComponent(out PlayerController playerController))
		{
			ActionManager.OnHitUpdate?.Invoke(playerController.data.CollectibleDamage);
			//Destroy(gameObject);
		}

	}
}
