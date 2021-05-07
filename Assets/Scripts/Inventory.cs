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

	public void RemoveByIndex(int i)
	{
		if (items[i] == null) { return; }
		items.RemoveAt(i);
	}

	public void Clear()
	{
		items.Clear();
	}
}