using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardOff : MonoBehaviour
{
    public GameObject g7;
    public GameObject g8;


    void Update()
    {
        if (SingletonCard2.isCardOn == false)
        {
            
            g8.SetActive(true);

            //현재 이미지 비활성화
            g7.SetActive(false);
        }
    }
}
