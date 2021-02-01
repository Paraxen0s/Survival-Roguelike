using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInstance : MonoBehaviour
{
	public Item item;

	public void Pickup(Inventory inventory)
	{
		inventory.Add(this.item);
		Destroy(this.gameObject);
	}
}
