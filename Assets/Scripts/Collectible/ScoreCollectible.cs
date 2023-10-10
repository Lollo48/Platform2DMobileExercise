using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCollectible : PickUpSystem
{
	protected override void PickUp(Collider2D collider)
	{
		if (collider.gameObject.TryGetComponent(out PlayerController playerController))
		{
			ActionManager.OnUpdateScore?.Invoke(playerController.data.ScorePickUp);
			Destroy(gameObject);
		}

	}
}
