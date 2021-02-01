using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
	public Color color;
	public Sprite icon;

	[Range(0, 100)]
	public float value = 100;
}
