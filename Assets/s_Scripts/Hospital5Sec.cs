using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Hospital5Sec : MonoBehaviour
{
    public GameObject tenth;
    public GameObject LastBtn;

    void Start()
    {
        StartCoroutine("FadeIn");
    }
    
    IEnumerator FadeIn()
    {
        yield return new WaitForSeconds(3f);
        //10��° �̹���, ������ Ȯ�� ��ư Ȱ��ȭ
        tenth.SetActive(true);
        LastBtn.SetActive(true);
        //���� �̹��� ��Ȱ��ȭ
        gameObject.SetActive(false);
        
    }
}
