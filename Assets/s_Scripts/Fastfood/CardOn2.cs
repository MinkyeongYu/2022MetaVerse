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
        //�Ʒ��κ��� �ٸ� ��ũ��Ʈ�� ���� (�̹���)
        //ī�带 �����ϸ�
        if (SingletonCard3.isCardOn2 == true)
        {
            //ī�廩��� �̹���
            g7.SetActive(true);
            //ī�带 ���ּ���
            audioSource.Play();
            //���� �̹��� ��Ȱ��ȭ
            g6.SetActive(false);
        }
    }
}
