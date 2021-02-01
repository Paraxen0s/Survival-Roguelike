using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerLook : MonoBehaviour
{
	private Vector2 lookDir;
	private Vector2 onLook;

	public Transform head;
	public float lookMult;

	public void Look(InputAction.CallbackContext context)
	{
		onLook = context.ReadValue<Vector2>();
	}

	void Update()
	{
		//rotate in direction of mouse movement
		lookDir.x += onLook.x * lookMult;
		lookDir.y += onLook.y * lookMult;

		//clamp x axis (y value) so as not to do backflips with the camera
		lookDir.y = Mathf.Clamp(lookDir.y, -90, 90);
	}

	void FixedUpdate()
	{
		//rotation of body along y axis
		transform.localRotation = Quaternion.Euler(Vector3.up * lookDir.x);

		//rotation of head along x axis
		head.transform.localRotation = Quaternion.Euler(Vector3.right * -lookDir.y);
	}
}
