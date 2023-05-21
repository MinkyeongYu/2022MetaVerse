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
        //카드투입구에 카드가 닿으면 중력 적용 (카드가 껴있는 느낌)
        if (col.tag == "CardEntry")
        {
            isCard = true;
            rigid.useGravity = true;
        }
        else
        {
            //카드 투입구와 멀어지면 중력 미적용
            rigid.useGravity = false;
        }
    }
}
