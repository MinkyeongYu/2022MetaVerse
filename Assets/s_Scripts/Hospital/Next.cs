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
    //gm�� ȯ�ڹ�ȣ ������Ʈ �̸�. ������Ʈ �̸��� ȯ�ڹ�ȣ �״�� �����Ѵ�
    public GameObject gm;

    [SerializeField] List<GameObject> Gb = new List<GameObject>();
    [SerializeField] List<GameObject> Btn = new List<GameObject>();
    public GameObject[] Key;


    void Update()
    {
        if ((Btn[0].GetComponent<Toggle>().isOn == true)&&(f.text == gm.name)&& (OkScript.okBtnClicked == true))
        {
            //���� �̹���, ��ư �����
            Gb[0].SetActive(false);
            Btn[0].SetActive(false);
            Btn[1].SetActive(false);
            Btn[2].SetActive(false);
            Btn[3].SetActive(false);
            //���� �̹���, ��ư ��Ÿ����
            Gb[1].SetActive(true);
            Btn[4].SetActive(true);

            //audio ����
            ad.Play();
            //Keypad �����
            for(int i=0; i < Key.Length; i++)
            {
                Key[i].SetActive(false);
            }
            //Ȯ�ι�ư �ʱ�ȭ
            OkScript.okBtnClicked = false;
            //inputField �ʱ�ȭ
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
