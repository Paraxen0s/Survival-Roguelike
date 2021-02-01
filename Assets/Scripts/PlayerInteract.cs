using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteract : MonoBehaviour
{
	public Transform head;
	public Inventory inventory;

	public void Interact(InputAction.CallbackContext context)
	{
		if (context.started && Physics.Raycast(head.transform.position, head.transform.forward, out RaycastHit hit, 20f))
		{
			ItemInstance item = hit.collider.gameObject.GetComponentInParent<ItemInstance>();
			if (inventory.items.Count < inventory.max)
			{
				item?.Pickup(inventory);
			}
		}
	}
}
