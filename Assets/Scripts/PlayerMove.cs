using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
	private Vector3 moveDir;
	private Vector3 onMove;

	public Rigidbody rb;
	public float walkMult;

	public void Move(InputAction.CallbackContext context)
	{
		onMove.x = context.ReadValue<Vector2>().x;
		//put y input value into onmove's z value, so onmove's y value can be replaced with current vertical velocity
		onMove.z = context.ReadValue<Vector2>().y;
	}

	void Update()
	{
		//move in direction based on local forward
		moveDir = transform.TransformDirection(onMove) * walkMult;
		//overwrite y velocity with whatever the rigidbody is already moving at
		moveDir.y = rb.velocity.y;
	}

	void FixedUpdate()
	{
		//apply velocity
		rb.velocity = moveDir;
	}
}
