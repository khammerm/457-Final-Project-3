using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float health = 100f;

    public HealthBar healthBar;

    // start player at max health (100 may be a bit high, but we can scale enemy damage) 
    void Start()
    {
        healthBar.SetMaxHealth(health);
    }

    // may use this later
    void Update()
    { 
        // press z to simulate player taking dmg, demonstrate color gradient
        if(Input.GetKeyDown(KeyCode.Z))
        {
           TakeDamage(20f);
        }
    }

    // simple take damage script for when we implement enemy AI.
    void TakeDamage(float damage)
    {
        health -= damage;
        healthBar.SetHealth(health);
    }
}
