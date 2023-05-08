using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int pointStealAmount = 10;


    public float moveSpeed = 5f;


    public float runSpeed = 10f;


    private bool hasStolenPoints = false;


    private Vector3 spawnPoint;


    private MainCharacter mainCharacterScript;


    public Score score;

   

    private void Start()
    {
  
        spawnPoint = transform.position;

       // player = GameObject.FindObjectOfType<MainCharacter>();


  
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            mainCharacterScript = player.GetComponent<MainCharacter>();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player" && !hasStolenPoints)
        {
            if (collision.gameObject.tag == "Player")
            {

                score.SubtractPoints(10);



                hasStolenPoints = true;

                transform.Rotate(Vector3.up, 180f);
            }
        }
    }

    // This function is called every frame
    private void Update()
    {

        if (mainCharacterScript != null && !hasStolenPoints)
        {

            GameObject mainCharacter = GameObject.FindGameObjectWithTag("Player");


            Vector3 direction = mainCharacter.transform.position - transform.position;


            direction.Normalize();


            transform.position += direction * moveSpeed * Time.deltaTime;
        }
        else
        {

            Vector3 direction = spawnPoint - transform.position;


            direction.Normalize();


            transform.position += direction * runSpeed * Time.deltaTime;


            if (Vector3.Distance(transform.position, spawnPoint) < 0.1f)
            {

               // Destroy(gameObject);
            }
        }
    }
}
