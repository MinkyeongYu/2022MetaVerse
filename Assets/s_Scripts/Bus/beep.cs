using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beep : MonoBehaviour
{
    public AudioSource audioSource;

    public void BeepPlay()
    {
        audioSource.Play();
    }
}
