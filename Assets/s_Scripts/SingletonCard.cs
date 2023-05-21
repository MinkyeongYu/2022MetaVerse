using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonCard : MonoBehaviour
{
    public static bool isCard;
    private Rigidbody rigid;

    void Start()
    {
        isCard = false;
        rigid = GetComponent<Rigidbody>();
        rigid.useGravity = false;
    }
    void OnTriggerEnter(Collider col)
    {
        //ī�����Ա��� ī�尡 ������ �߷� ���� (ī�尡 ���ִ� ����)
        if (col.tag == "CardEntry")
        {
            isCard = true;
            rigid.useGravity = true;
        }
        else
        {
            //ī�� ���Ա��� �־����� �߷� ������
            rigid.useGravity = false;
        }
    }
}
