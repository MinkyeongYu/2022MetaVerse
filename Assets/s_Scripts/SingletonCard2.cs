using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonCard2 : MonoBehaviour
{
    public static bool isCardOn;
    private Rigidbody rigid;

    void Start()
    {
        isCardOn = false;
        rigid = GetComponent<Rigidbody>();
        rigid.useGravity = false;
    }
    void OnTriggerEnter(Collider col)
    {
        //ī�����Ա��� ī�尡 ������ �߷� ���� (ī�尡 ���ִ� ����)
        if (col.tag == "CardEntry")
        {
            isCardOn = true;
            rigid.useGravity = true;
        }
        else
        {
            isCardOn = false;
            rigid.useGravity = false;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if(col.tag == "CardEntry")
        {
            isCardOn = false;
            rigid.useGravity = false;
        }
    }
    
}
