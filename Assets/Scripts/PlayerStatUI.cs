using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteAlways]
public class PlayerStatUI : MonoBehaviour
{
	public PlayerStat stat;

	[SerializeField]
	private Slider slider = null;
	[SerializeField]
	private Image fillRef = null;
	[SerializeField]
	private Image iconRef = null;

	private void Start()
	{
		this.name = stat.name + " Meter";
		fillRef.color = stat.color;
		iconRef.sprite = stat.icon;
	}

	private void UpdateValue()
	{
		slider.value = stat.value / 100;
	}

	private void Update()
	{
		UpdateValue();
	}
}