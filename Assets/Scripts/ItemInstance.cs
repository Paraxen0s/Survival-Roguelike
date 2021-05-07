using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInstance : MonoBehaviour
{
	public Item item;
	float durability = 0;

	private void Start()
	{
		durability = item.durability;
	}

	public void Pickup(Inventory inventory)
	{
		inventory.Add(this.item);
		Destroy(this.gameObject);
	}
}
