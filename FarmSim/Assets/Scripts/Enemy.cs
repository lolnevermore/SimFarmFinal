using UnityEngine;

public class Enemy : MonoBehaviour
{
    // how many points the enemy will steal
    public int pointStealAmount = 10;

    // speed at which the enemy moves towards the main character
    public float moveSpeed = 5f;

    // speed at which the enemy runs away from the main character
    public float runSpeed = 10f;

    // track of whether the enemy has already stolen points
    private bool hasStolenPoints = false;

    
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the object the enemy collided with is the main character
        if (collision.gameObject.tag == "Player" && !hasStolenPoints)
        {
            // Get the MainCharacter script from the main character game object
            MainCharacter mainCharacter = collision.gameObject.GetComponent<MainCharacter>();

            // Check if the MainCharacter script exists
            if (mainCharacter != null)
            {
                // Call the function in the MainCharacter script to subtract points
                mainCharacter.SubtractPoints(pointStealAmount);

                // Set hasStolenPoints to true so the enemy will start running away
                hasStolenPoints = true;
            }
        }
    }

    // This function is called every frame
    private void Update()
    {
        // Find the main character game object
        GameObject mainCharacter = GameObject.FindGameObjectWithTag("Player");

        // Check if the main character exists
        if (mainCharacter != null)
        {
            if (!hasStolenPoints)
            {
                // Calculate the direction from the enemy to the main character
                Vector3 direction = mainCharacter.transform.position - transform.position;

                // Normalize the direction vector to a length of 1
                direction.Normalize();

                // Move the enemy towards the main character
                transform.position += direction * moveSpeed * Time.deltaTime;
            }
            else
            {
                // Calculate the direction from the enemy to the main character
                Vector3 direction = transform.position - mainCharacter.transform.position;

                // Normalize the direction vector to a length of 1
                direction.Normalize();

                // Move the enemy away from the main character
                transform.position += direction * runSpeed * Time.deltaTime;
            }
        }
    }
}
