using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;
using UnityEngine.SceneManagement;

public class BusTerKiosk : MonoBehaviour
{
    [SerializeField] List<GameObject> Gb = new List<GameObject>();
    [SerializeField] List<GameObject> Btn = new List<GameObject>();
    [SerializeField] string scene;

    public AudioSource[] audioSource;
    public GameObject sound;

    // 1
    public void firstClicked()
    {
        Gb[0].SetActive(false);
        Btn[0].SetActive(false);
        sound.SetActive(false);

        //�λ��ؿ�� ����~
        audioSource[0].Play();

        //�λ��ؿ�� ��ư, ������ ���� �̹��� Ȱ��ȭ
        Gb[1].SetActive(true);
        Btn[1].SetActive(true);

    }
   


    //2, �λ��ؿ�븦 �������� ������ ��
    public void secondClicked()
    {
        Gb[1].SetActive(false);
        Btn[1].SetActive(false);
        //�ð������̹���
        Gb[2].SetActive(true);
        //13:30�� ������ ����~
        audioSource[1].Play();
        //�ð����ù�ư
        Btn[2].SetActive(true);
    }

    // 3, 13:30�� ������ �����ϸ�, ���õ� ȭ�� ����
    public void thirdClicked()
    {
        Gb[2].SetActive(false);
        Btn[2].SetActive(false);
        //���õ� ȭ�� Ȱ��ȭ
        Gb[3].SetActive(true);
        //���� �Ϸᰡ �Ǿ����� ������ �����ּ���
        audioSource[2].Play();
        //�����ư Ȱ��ȭ
        Btn[3].SetActive(true);
    }
    // 4, �����ư�� ������, �¼� ���� ȭ�� Ȱ��ȭ
    public void fourthClicked()
    {
        Gb[3].SetActive(false);
        Btn[3].SetActive(false);

        //�¼� ���� �̹���
        Gb[4].SetActive(true);
        //25�� �¼��� �����ּ���
        audioSource[3].Play();
        //25�� �¼� ��ư 
        Btn[4].SetActive(true);
    }


    // 5, 25�� �¼��� �����ϸ�, 25�� ������ ���� Ȱ��ȭ
    public void fifthClicked()
    {
        Btn[4].SetActive(false);
        //�¼� ���� �̹���
        Gb[5].SetActive(true);
        //�¼� ������ �Ϸ�Ǿ����� Ȯ���� �����ּ���
        audioSource[4].Play();
        // Ȯ�ι�ư
        Btn[5].SetActive(true);
    }

    // 6, Ȯ�ι�ư�� ������, 
    public void SixthClicked()
    {
        Gb[5].SetActive(false);
        Btn[5].SetActive(false);

        //ī�� ���� �̹���
        Gb[6].SetActive(true);
        //ī�带 �־��ּ���
        audioSource[5].Play();


        ////�Ʒ��κ��� �ٸ� ��ũ��Ʈ�� ���� (�̹���)
        ////ī�带 �����ϸ�
        //if (SingletonCard2.isCardOn == true)
        //{
        //    Gb[6].SetActive(false);

        //    //ī�廩��� �̹���
        //    Gb[7].SetActive(true);
        //    //ī�带 ���ּ���
        //    audioSource[6].Play();
        //}
    }


    //// 7, ī�廩�� �߱�����.. �ڷ�ƾ, �ٸ� ��ũ��Ʈ�� ���� (�̹���)
    //public void seventhClicked()
    //{
    //    if (SingletonCard2.isCardOn == false)
    //    {
    //        Gb[7].SetActive(false);
    //        Gb[8].SetActive(true);
    //        audioSource[7].Play();

    //    }
    //}
    //������ ���ư��� ��ư ��������, ������ �� ��ȯ
    public void LoadingScene()
    {
        SceneManager.LoadScene(scene);
    }

}
