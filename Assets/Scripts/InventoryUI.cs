using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class InventoryUI : MonoBehaviour
{
	public GameObject inventoryCanvas;
	public Inventory inventory;
	public Transform content;
	public GameObject itemSlotPrefab;
	public List<ItemUI> itemSlots;

	public GameObject player;

	void Start()
	{
		itemSlots = new List<ItemUI>(GetComponentsInChildren<ItemUI>());
	}

	public virtual void Update()
	{
		Refresh();
	}

	public virtual void Refresh()
	{
		int i = 0;
		foreach (ItemUI slotUI in itemSlots)
		{
			slotUI.item = null;

			if (i < inventory.items.Count)
			{
				slotUI.item = inventory.items[i];
			}

			slotUI.Refresh();

			i++;
		}
	}

	public void UseItem(Item item)
	{
		inventory.Use(item);
	}
}
