using UnityEngine;
using System.Collections;

public class MenuPause : MonoBehaviour
{

	private bool isPaused = false;

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) {
			isPaused = !isPaused;
		}

		if (isPaused) {
			Time.timeScale = 0f;
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
		} else {
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
			Time.timeScale = 1.0f;
		}
	}

	void OnGUI ()
	{
		if (isPaused) {
			GUI.Box (new Rect (Screen.width / 2 - 100, Screen.height / 2 - 80, 200, 200), "Pause");

			if (GUI.Button (new Rect (Screen.width / 2 - 40, Screen.height / 2 - 20, 80, 40), "Continue")) {
				isPaused = false;
			}

			if (GUI.Button (new Rect (Screen.width / 2 - 40, Screen.height / 2 + 40, 80, 40), "Quitter")) {
				Application.Quit ();
			}
		}
	}
}
