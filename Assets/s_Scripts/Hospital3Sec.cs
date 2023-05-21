using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Hospital3Sec : MonoBehaviour
{
    public GameObject ninth;
    public AudioSource audioSource;

    void Start()
    {
        StartCoroutine("FadeIn"); 
    }

    IEnumerator FadeIn()
    {
        yield return new WaitForSeconds(3f);
        //9��° �̹���, 8��° ����� Ȱ��ȭ
        ninth.SetActive(true);
        audioSource.Play();
        //���� �̹��� ��Ȱ��ȭ
        gameObject.SetActive(false);
        
    }

}
