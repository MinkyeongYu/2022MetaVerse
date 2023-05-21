using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CokeClick2 : MonoBehaviour
{
    public static bool CokeOn = false;
    public static bool FriedOn = false;
    public static bool OrderNo = false;
    public GameObject[] gameObj;

    //콜라 클릭
    public void Coke()
    {
        CokeOn = true;
        gameObj[0].SetActive(false);
    }
    public void Fried()
    {
        FriedOn = true;
        gameObj[1].SetActive(false);
    }
    public void Order()
    {
        OrderNo = true;
        gameObj[2].SetActive(false);
    }
}
