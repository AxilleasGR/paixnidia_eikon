using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;

    public int currentHealth;

    public healthBar healthBar;
    // Start is called before the first frame update
    void Start()
    { 
        Cursor.visible = false;
        currentHealth = maxHealth;
        healthBar.SetHealth(maxHealth);
    }
    
    void TakeDamage(int dmg)
    {
        currentHealth -= dmg;
        healthBar.SetHealth(currentHealth);
    }
}
