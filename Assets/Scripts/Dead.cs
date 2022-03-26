using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class Dead : MonoBehaviour
{
    public int maxHealth = 100;
    
    public healthBar healthBar;
    public Transform teleportTarget;
    public GameObject player;
    public GameObject canvas;

    public void Restarter()
    {
        canvas.gameObject.SetActive(false);
        Time.timeScale = 1f;
        Cursor.visible = false;
        healthBar.SetHealth(maxHealth);
        player.transform.position = teleportTarget.transform.position;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
