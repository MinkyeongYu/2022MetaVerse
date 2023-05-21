using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Coroutine3Sec : MonoBehaviour
{

    public GameObject g9;
    public GameObject g8;
    public AudioSource audioSource;
    public AudioSource audioSource2;

    public GameObject go;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("CardOff");
    }

    // 7, 카드빼면 발권진행.. 코루틴, 다른 스크립트에 적용 (이미지)
    IEnumerator CardOff()
    {
        //잠시만 기다려주세요
        audioSource.Play();

        yield return new WaitForSeconds(3f);
        //출력 이미지 
        g9.SetActive(true);
        //Main으로 가주세요
        audioSource2.Play();
        //Main button
        go.SetActive(true);

        g8.SetActive(false);

    }
   
}
