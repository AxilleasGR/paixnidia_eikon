using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageWater : MonoBehaviour
{
    private bool inTrigger=false;
    public int maxHealth = 100;

    public int currentHealth;
    public healthBar healthBar;
    
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("damager", 2.0f, 1f);
        currentHealth = maxHealth;
        healthBar.SetHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    private void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
    }
    private void OnTriggerExit(Collider other)
    {
        inTrigger = false;
    }

    public void SetHealthWater(int health)
    {
        currentHealth = health;
    }

    void damager()
    {
        if(inTrigger)
            TakeDamage(5);
    }
    void TakeDamage(int dmg)
    {
        currentHealth -= dmg;
        if (currentHealth == 0)
        {
            currentHealth = maxHealth;
            Cursor.visible = true;
            canvas.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
        healthBar.SetHealth(currentHealth);
    }
    
}
