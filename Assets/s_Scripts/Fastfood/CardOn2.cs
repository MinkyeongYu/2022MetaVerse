using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class CardOn2 : MonoBehaviour
{
    public GameObject g6;
    public GameObject g7;
    public AudioSource audioSource;


    void Update()
    {
        //아래부분은 다른 스크립트에 적용 (이미지)
        //카드를 삽입하면
        if (SingletonCard3.isCardOn2 == true)
        {
            //카드빼라는 이미지
            g7.SetActive(true);
            //카드를 빼주세요
            audioSource.Play();
            //현재 이미지 비활성화
            g6.SetActive(false);
        }
    }
}
