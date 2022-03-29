using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    // start player at max health (100 may be a bit high, but we can scale enemy damage) 
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // may use this later
    void Update()
    { 
        // press z to simulate player taking dmg, demonstrate color gradient
        if(Input.GetKeyDown(KeyCode.Z))
        {
           TakeDamage(20);
        }
    }

    // simple take damage script for when we implement enemy AI.
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}
