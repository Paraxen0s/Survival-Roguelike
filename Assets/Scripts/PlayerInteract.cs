using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteract : MonoBehaviour
{
	public Transform head;
	public Inventory inventory;

	//public PlayerLook looking;

	bool isCursorLocked;

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

	public void Start()
	{
		Cursor.lockState = CursorLockMode.Locked;
		isCursorLocked = true;
		//	looking.enabled = false;
	}

	public void ToggleCursor(InputAction.CallbackContext context)
	{
		if (context.started)
		{
			//	if (!((Cursor.lockState == CursorLockMode.Confined && isCursorLocked && !looking.enabled) ||
			//			(Cursor.lockState == CursorLockMode.Locked && !isCursorLocked && looking.enabled)))
			//	{
			Cursor.lockState = CursorLockMode.Confined;
			isCursorLocked = true;
			//	looking.enabled = false;
			//	}

			Cursor.lockState = isCursorLocked ? CursorLockMode.Locked : CursorLockMode.Confined;
			isCursorLocked = !isCursorLocked;
			//	looking.enabled = !looking.enabled;
		}
	}
}
