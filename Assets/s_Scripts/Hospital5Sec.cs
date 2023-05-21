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
        //10번째 이미지, 마지막 확인 버튼 활성화
        tenth.SetActive(true);
        LastBtn.SetActive(true);
        //현재 이미지 비활성화
        gameObject.SetActive(false);
        
    }
}
