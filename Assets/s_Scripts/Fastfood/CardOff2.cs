using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardOff2 : MonoBehaviour
{
    public GameObject g7;
    public GameObject g8;
    public AudioSource a;

    void Update()
    {
        if (SingletonCard3.isCardOn2 == false)
        {

            g8.SetActive(true);

            a.Play();

            //���� �̹��� ��Ȱ��ȭ
            g7.SetActive(false);

            
        }
    }
}
