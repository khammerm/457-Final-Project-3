
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;
    MeshRenderer meshRenderer;
    Color origColor;
    float flashTime = .1f;

    public AudioSource enemyDieSound;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        origColor = meshRenderer.material.color;
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

