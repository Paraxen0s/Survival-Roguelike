using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemUI : MonoBehaviour
{
	public Item item;
	[Space]
	public Button button;
	public Image image;

	public void Refresh()
	{
		if (item)
		{
			if (image.enabled == false) { image.enabled = true; }
			image.sprite = item.icon;
		}
		else
		{
			image.sprite = null;
			image.enabled = false;
		}
	}
}
