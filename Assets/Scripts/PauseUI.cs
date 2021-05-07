using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PauseUI : MonoBehaviour
{
	public GameObject pauseUI;
	CursorLockMode oldCursorMode;
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
		Cursor.lockState = oldCursorMode;
		pauseUI.SetActive(false);
		Time.timeScale = 1f;
		isPaused = false;
	}

	public void Pause()
	{
		oldCursorMode = Cursor.lockState;
		Cursor.lockState = CursorLockMode.None;
		pauseUI.SetActive(true);
		Time.timeScale = 0f;
		isPaused = true;
	}
}
