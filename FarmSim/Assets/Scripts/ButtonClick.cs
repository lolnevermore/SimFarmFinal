using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public AudioSource sauce;

    public void buttonClick()
    {
        sauce.Play();
    }
}
