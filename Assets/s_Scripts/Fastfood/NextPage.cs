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

            //다음 이미지, 버튼 활성화
            g.SetActive(true);
            gd.SetActive(true);

            //다음 오디오 활성화
            a.Play();
        }
    }
}
