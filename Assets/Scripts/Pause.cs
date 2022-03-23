using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool gameIsPaused = false;

    public GameObject canvas;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused==true)
            {
                Resume();
            }
            else
            {
                Pauser();
            }
        }
    }

    public void Resume()
    {
        canvas.gameObject.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
        Cursor.visible = false;
    }

    public void Pauser()
    {
        canvas.gameObject.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
        Cursor.visible = true;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
