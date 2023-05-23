using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public int pointStealAmount = 10;
    public float runSpeed = 10f;

    private bool hasStolenPoints = false;
    private Vector3 spawnPoint;
    private MainCharacter mainCharacterScript;
    private Score score;
    private NavMeshAgent navMeshAgent;
    public AudioClip swipe;
    public AudioSource srce;
    public ParticleSystem particles;

    private void Start()
    {
        spawnPoint = transform.position;

        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            mainCharacterScript = player.GetComponent<MainCharacter>();
        }

        score = FindObjectOfType<Score>();

        navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.updateRotation = false;
        navMeshAgent.stoppingDistance = 1f;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && !hasStolenPoints)
        {
            score.SubtractPoints(pointStealAmount);
            srce.PlayOneShot(swipe);
            hasStolenPoints = true;
            transform.Rotate(Vector3.up, 180f);
        }
    }

    private void Update()
    {
        if (mainCharacterScript != null && !hasStolenPoints)
        {
            navMeshAgent.destination = mainCharacterScript.transform.position;
            particles.Play();
        }
        else
        {
            navMeshAgent.destination = spawnPoint;
            if (Vector3.Distance(transform.position, spawnPoint) < 0.1f)
            {
                Destroy(gameObject);
            }
        }

        if (navMeshAgent.hasPath)
        {
            Vector3 direction = navMeshAgent.steeringTarget - transform.position;
            direction.y = 0;
            if (direction.magnitude > 0.1f)
            {
                Quaternion targetRotation = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * 5f);
            }
        }
    }
}
