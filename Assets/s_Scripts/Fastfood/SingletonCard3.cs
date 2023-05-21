using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonCard3 : MonoBehaviour
{
    public static bool isCardOn2;
    private Rigidbody rigid;

    void Start()
    {
        isCardOn2 = false;
        rigid = GetComponent<Rigidbody>();
        rigid.useGravity = false;
    }
    void OnTriggerEnter(Collider col)
    {
        //ī�����Ա��� ī�尡 ������ �߷� ���� (ī�尡 ���ִ� ����)
        if (col.tag == "CardEntry")
        {
            isCardOn2 = true;
            rigid.useGravity = true;
        }
        else
        {
            isCardOn2 = false;
            rigid.useGravity = false;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "CardEntry")
        {
            isCardOn2 = false;
            rigid.useGravity = false;
        }
    }

}