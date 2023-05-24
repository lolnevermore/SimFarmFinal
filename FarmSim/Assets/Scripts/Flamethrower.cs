using UnityEngine;
using UnityEngine.Audio;

public class Flamethrower : MonoBehaviour
{
    public ParticleSystem particles;
    public float damage = 10f;
    public AudioClip fire;
    public AudioSource source;

    private void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            particles.Play();
            //source.PlayOneShot(fire);
            playFire();
        }
        else
        {
            particles.Stop();
            stopFire();
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

    private void playFire()
    {
        source.PlayOneShot(fire);
    }

    private void stopFire()
    {
        source.Stop();
    }
}
