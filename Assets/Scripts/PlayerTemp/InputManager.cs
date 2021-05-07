using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
	public PlayerControls controls;
	public static InputManager Instance;

	void Awake()
	{
		controls = new PlayerControls();
		if (Instance == null)
		{
			Instance = this;
		}
		else
		{
			Destroy(gameObject);
		}

		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	void OnEnable()
	{
		controls.Enable();
	}

	void OnDisable()
	{
		controls.Disable();
	}

	public Vector2 moveDirection;
	public Vector2 lookDelta;
	public bool jumpButton;

	void Update()
	{
		moveDirection = controls.Player.Move.ReadValue<Vector2>();
		lookDelta = controls.Player.Look.ReadValue<Vector2>();
		//	jumpButton = controls.Player.Jump.ReadValue<float>() > 0 ? true : false;
	}
}
