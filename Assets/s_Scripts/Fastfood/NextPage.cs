using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextPage : MonoBehaviour
{
    public GameObject curr;
    public GameObject g;
    public GameObject gd;
    public AudioSource a;
    void Update()
    {
        if(CokeClick.CokeOn==true&&CokeClick.FriedOn==true&&CokeClick.OrderNo==true)
        {
            curr.SetActive(false);

            //���� �̹���, ��ư Ȱ��ȭ
            g.SetActive(true);
            gd.SetActive(true);

            //���� ����� Ȱ��ȭ
            a.Play();
        }
    }
}
