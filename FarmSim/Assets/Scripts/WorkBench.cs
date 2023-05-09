using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkBench : MonoBehaviour
{
    public bool hasTriggered = false;
    public GameObject Success;

    private void Start()
    {
        Success.SetActive(false);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasTriggered && Input.GetKey(KeyCode.Space))
        {
            hasTriggered = true;
            Success.SetActive(true);
            Time.timeScale = 0f;

        }
        else if (Input.GetKeyDown(KeyCode.Backspace))
        {
            hasTriggered = false;
            Success.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}
