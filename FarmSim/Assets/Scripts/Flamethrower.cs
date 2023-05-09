using UnityEngine;

public class Flamethrower : MonoBehaviour
{
    public ParticleSystem particles;
    public float damage = 10f;

    private void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            particles.Play();
        }
        else
        {
            particles.Stop();
        }
    }

    private void OnParticleCollision(GameObject other)
    {
        BlightHealth enemy = other.GetComponent<BlightHealth>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
    }
}
