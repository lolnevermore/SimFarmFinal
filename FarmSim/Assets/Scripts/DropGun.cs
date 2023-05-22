using UnityEngine;

public class DropGun : MonoBehaviour
{
    public float dropDistance = 2f; // The distance in front of the player where the flamethrower should be dropped
    public Transform pickupParent; // Parent object for the flamethrower when it's picked up

    public bool isPickedUp = true; // Initially set to true so that the flamethrower is picked up
    private Transform playerTransform; // Reference to the player's transform

    // Add any necessary references to other scripts, particle systems, colliders, etc.
    public ParticleSystem flamesParticles;
    public Collider flamethrowerCollider;

    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform; // Find the player's transform by tag
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            if (isPickedUp)
            {
                DropFlamethrower();
            }
            else
            {
                PickUpFlamethrower();
            }
        }
    }

    private void DropFlamethrower()
    {
        isPickedUp = false;

        // Disable flamethrower-related scripts, visual effects, or colliders
        flamesParticles.Stop(); // Stop the flamethrower particle system
        flamethrowerCollider.enabled = false; // Disable the flamethrower collider

        // Calculate the drop position in front of the player
        Vector3 dropPosition = playerTransform.position + playerTransform.forward * dropDistance;

        // Set the flamethrower's position to the drop position
        transform.parent = null; // Unparent the flamethrower from the player
        transform.position = dropPosition;
        transform.rotation = playerTransform.rotation;
    }

    private void PickUpFlamethrower()
    {
        isPickedUp = true;

        // Enable flamethrower-related scripts, visual effects, or colliders
        flamesParticles.Play(); // Start the flamethrower particle system
        flamethrowerCollider.enabled = true; // Enable the flamethrower collider

        // Set the flamethrower's position and parent it to the pickup parent
        transform.parent = pickupParent;
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;
    }
}
