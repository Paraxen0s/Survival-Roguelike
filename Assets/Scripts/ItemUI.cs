using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.Events;

[System.Serializable]
public class ItemUIEvent : UnityEvent<ItemUI> { }

public class ItemUI : MonoBehaviour
{
	public Item item;
	public Image iconRef;

	public void Refresh()
	{
		if (item)
		{
			if (iconRef.enabled == false) { iconRef.enabled = true; }
			iconRef.sprite = item.icon;
		}
		else
		{
			iconRef.sprite = null;
			iconRef.enabled = false;
		}
	}
}
