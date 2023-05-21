using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Next : MonoBehaviour
{
    //narration
    public AudioSource ad;
    // inputField 
    public InputField f;
    //gm은 환자번호 오브젝트 이름. 오브젝트 이름을 환자번호 그대로 설정한다
    public GameObject gm;

    [SerializeField] List<GameObject> Gb = new List<GameObject>();
    [SerializeField] List<GameObject> Btn = new List<GameObject>();
    public GameObject[] Key;


    void Update()
    {
        if ((Btn[0].GetComponent<Toggle>().isOn == true)&&(f.text == gm.name)&& (OkScript.okBtnClicked == true))
        {
            //현재 이미지, 버튼 숨기기
            Gb[0].SetActive(false);
            Btn[0].SetActive(false);
            Btn[1].SetActive(false);
            Btn[2].SetActive(false);
            Btn[3].SetActive(false);
            //다음 이미지, 버튼 나타내기
            Gb[1].SetActive(true);
            Btn[4].SetActive(true);

            //audio 실행
            ad.Play();
            //Keypad 숨기기
            for(int i=0; i < Key.Length; i++)
            {
                Key[i].SetActive(false);
            }
            //확인버튼 초기화
            OkScript.okBtnClicked = false;
            //inputField 초기화
            f.text = "";
        }

        //if (f.text == gm.name)
        //{
        //    if (OkScript.okBtnClicked == true)
        //    {
        //        a.SetActive(true);
        //        b.SetActive(false);
        //        ad.Play();
        //        OkScript.okBtnClicked = false;
        //    }
        //}
    }
}
