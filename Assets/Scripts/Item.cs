using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Item : ScriptableObject
{
	public Sprite icon;
	public GameObject physical;

	public void Use()
	{
		// what it does or whatever
	}
}