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
        //9번째 이미지, 8번째 오디오 활성화
        ninth.SetActive(true);
        audioSource.Play();
        //현재 이미지 비활성화
        gameObject.SetActive(false);
        
    }

}
