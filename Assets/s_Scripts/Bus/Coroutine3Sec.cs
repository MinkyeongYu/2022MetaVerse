using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Coroutine3Sec : MonoBehaviour
{

    public GameObject g9;
    public GameObject g8;
    public AudioSource audioSource;
    public AudioSource audioSource2;

    public GameObject go;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("CardOff");
    }

    // 7, ī�廩�� �߱�����.. �ڷ�ƾ, �ٸ� ��ũ��Ʈ�� ���� (�̹���)
    IEnumerator CardOff()
    {
        //��ø� ��ٷ��ּ���
        audioSource.Play();

        yield return new WaitForSeconds(3f);
        //��� �̹��� 
        g9.SetActive(true);
        //Main���� ���ּ���
        audioSource2.Play();
        //Main button
        go.SetActive(true);

        g8.SetActive(false);

    }
   
}