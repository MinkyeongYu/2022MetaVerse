using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class CardOn3 : MonoBehaviour
{
    public GameObject g6;
    public GameObject g7;


    void Update()
    {
        //아래부분은 다른 스크립트에 적용 (이미지)
        //카드를 삽입하면
        if (SingletonCard4.isCardOn3 == true)
        {
            //카드빼라는 이미지
            g7.SetActive(true);

            //현재 이미지 비활성화
            g6.SetActive(false);
        }
    }
}
