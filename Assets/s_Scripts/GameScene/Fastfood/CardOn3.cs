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
        //�Ʒ��κ��� �ٸ� ��ũ��Ʈ�� ���� (�̹���)
        //ī�带 �����ϸ�
        if (SingletonCard4.isCardOn3 == true)
        {
            //ī�廩��� �̹���
            g7.SetActive(true);

            //���� �̹��� ��Ȱ��ȭ
            g6.SetActive(false);
        }
    }
}
