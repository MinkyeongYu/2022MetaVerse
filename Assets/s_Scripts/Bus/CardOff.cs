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

            //���� �̹��� ��Ȱ��ȭ
            g7.SetActive(false);
        }
    }
}
