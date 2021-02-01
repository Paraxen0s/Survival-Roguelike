using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
	public List<Item> items;
	public int max;

	public void Add(Item item)
	{
		items.Add(item);
	}

	public void Remove(Item item)
	{
		if (!items.Contains(item)) { return; }
		items.Remove(item);
	}

	public void Use(Item item)
	{
		item.Use();
		items.Remove(item);
	}
}  