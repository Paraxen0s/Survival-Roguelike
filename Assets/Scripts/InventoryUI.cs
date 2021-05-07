using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InventoryUI : MonoBehaviour
{
	public Inventory inventory;
	public Transform content;
	public GameObject prefab;

	public List<ItemUI> itemSlots;

	private void Awake()
	{
		itemSlots.Clear();
		foreach (Transform slot in content.transform)
		{
			Destroy(slot.gameObject);
		}

		for (int i = 0; i < 6; i++)
		{
			itemSlots.Add(GameObject.Instantiate(prefab, content).GetComponent<ItemUI>());
		}
	}

	private void Update()
	{
		Refresh();
	}

	public void Refresh()
	{
		for (int i = 0; i < itemSlots.Count; i++)
		{
			itemSlots[i].item = null;
			if (i < inventory.items.Count)
			{
				itemSlots[i].item = inventory.items[i];
			}
			itemSlots[i].Refresh();
		}
	}
}