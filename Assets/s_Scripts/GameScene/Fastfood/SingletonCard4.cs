using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonCard4 : MonoBehaviour
{
    public static bool isCardOn3;
    private Rigidbody rigid;

    void Start()
    {
        isCardOn3 = false;
        rigid = GetComponent<Rigidbody>();
        rigid.useGravity = false;
    }
    void OnTriggerEnter(Collider col)
    {
        //ī�����Ա��� ī�尡 ������ �߷� ���� (ī�尡 ���ִ� ����)
        if (col.tag == "CardEntry")
        {
            isCardOn3 = true;
            rigid.useGravity = true;
        }
        else
        {
            isCardOn3 = false;
            rigid.useGravity = false;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "CardEntry")
        {
            isCardOn3 = false;
            rigid.useGravity = false;
        }
    }

}