using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextPage2 : MonoBehaviour
{
    public GameObject curr;
    public GameObject g;
    public GameObject gd;

    void Update()
    {
        if (CokeClick2.CokeOn == true && CokeClick2.FriedOn == true && CokeClick2.OrderNo == true)
        {
            curr.SetActive(false);

            //다음 이미지, 버튼 활성화
            g.SetActive(true);
            gd.SetActive(true);
        }
    }
}
