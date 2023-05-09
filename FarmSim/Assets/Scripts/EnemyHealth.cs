using UnityEngine;
using UnityEngine.Audio;

public class EnemyHealth : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;
    public float delay = 1f;
    public AudioSource deathSource;
    public AudioClip deathClip;
    //public bool isDestroyed = false;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float damageAmount)
    {
        currentHealth -= damageAmount;
        if (currentHealth <= 0f)
        {
            deathSource.PlayOneShot(deathClip);

            Die();
        }
    }

    private void Die()
    {
        // Destroy the enemy object
        //isDestroyed = true;
        Destroy(gameObject, delay);
    }
}
