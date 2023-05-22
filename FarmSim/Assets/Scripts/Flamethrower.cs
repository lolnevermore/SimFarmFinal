using UnityEngine;
using UnityEngine.Audio;

public class Flamethrower : MonoBehaviour
{
    public ParticleSystem particles;
    public float damage = 10f;
    public AudioClip fire;
    public AudioSource source;
    public DropGun dropGun;
    public bool isPickedUp = true;

    private void Update()
    {
        if (Input.GetButton("Fire1") && (isPickedUp = true))
        {
            particles.Play();
            source.PlayOneShot(fire);
        }
        else
        {
            particles.Stop();
            isPickedUp = false;
        }
    }

    private void OnParticleCollision(GameObject other)
    {
        EnemyHealth enemyHealth = other.GetComponent<EnemyHealth>();
        if (enemyHealth != null)
        {
            enemyHealth.TakeDamage(damage);
        }
    }
}
