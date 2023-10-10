using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPCollectible : PickUpSystem
{

    protected override void PickUp(Collider2D collider)
    {
		if (collider.gameObject.TryGetComponent(out PlayerController playerController))
		{
			//Debug.Log("PLAYERCONTROLLER");
			if (playerController.data.HP == playerController.data.MaxHP) return;

			else
			{
				ActionManager.OnhealtRecharge?.Invoke(playerController.data.RestoreHP);
				Destroy(gameObject);
			}

			if (playerController.data.HP > playerController.data.MaxHP) playerController.data.HP = playerController.data.MaxHP;
		}

	}


}
