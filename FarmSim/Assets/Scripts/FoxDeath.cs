using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class FoxDeath : MonoBehaviour
{
    public GameObject fox;
    public AudioSource deathSource;
    public AudioClip deathClip;

    private void OnDestroy()
    {
        deathSource.PlayOneShot(deathClip);
    }
}
