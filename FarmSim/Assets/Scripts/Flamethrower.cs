using UnityEngine;

public class Flamethrower : MonoBehaviour
{
    public ParticleSystem particles;
    public float damage = 10f;
    //public GameObject[] blight;
    public GameObject[] enemy;

    private void Start()
    {
        
    }
    public void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            particles.Play();
        }
        else
        {
            particles.Stop();
        }
        
        for (int i=0; i < enemy.Length; i++)
        {
            enemy[i] = GameObject.FindGameObjectWithTag("Enemy");
        }
                
        //blight = new GameObject[] { enemy };
    }

    public void OnParticleCollision(GameObject other)
    {
        //BlightHealth enemy = other.gameObject.tag == "Enemy";
        if (enemy != null)
        {
            foreach (GameObject blight in enemy)
            {
                blight.gameObject.GetComponent<BlightHealth>().TakeDamage(damage);
            }
            
        }
    }
}
