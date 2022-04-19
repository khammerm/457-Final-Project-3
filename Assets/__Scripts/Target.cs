using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;
    MeshRenderer meshRenderer;
    Color origColor;
    float flashTime = .1f;

    public AudioSource enemyDieSound;
    public AmmoDisplay ammoObject;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        origColor = meshRenderer.material.color;
        //ammoObject.killedTarget();
    }
    public void TakeDamage(float amount){
        health -= amount;
        FlashStart();
        if(health <= 0f)
        {
            Die();
        }
    }
    void Die()
    {
        if(enemyDieSound != null)
            enemyDieSound.Play();
        Destroy(gameObject);
        ammoObject.killedTarget();
    }
    void FlashStart()
    {
        meshRenderer.material.color = Color.red;
        Invoke("FlashStop", flashTime);
    }
    void FlashStop()
    {
        meshRenderer.material.color = origColor;
    }
}

