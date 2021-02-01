using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PauseUI : MonoBehaviour
{
	public GameObject pauseUI;

	private bool isPaused;

	private void Start()
	{
		if (isPaused)
		{
			Pause();
		}
		else
		{
			Resume();
		}
	}

	public void TogglePause(InputAction.CallbackContext context)
	{
		if (context.canceled)
		{
			if (isPaused)
			{
				Resume();
			}
			else
			{
				Pause();
			}
		}
	}

	public void Resume()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		pauseUI.SetActive(false);
		Time.timeScale = 1f;

		isPaused = false;
	}

	public void Pause()
	{
		Cursor.lockState = CursorLockMode.Confined;
		Cursor.visible = true;
		pauseUI.SetActive(true);
		Time.timeScale = 0f;

		isPaused = true;
	}
}
