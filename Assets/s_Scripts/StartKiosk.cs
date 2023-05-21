using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartKiosk : MonoBehaviour
{
    [SerializeField] public AudioSource audioSource;

    public void OnTriggerEnter(Collider col)
    {
        audioSource.Play();
    }

}