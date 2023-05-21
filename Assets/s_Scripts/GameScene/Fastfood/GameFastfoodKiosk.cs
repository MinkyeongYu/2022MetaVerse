using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFastfoodKiosk : MonoBehaviour
{
    [SerializeField] List<GameObject> Gb = new List<GameObject>();
    [SerializeField] List<GameObject> Btn = new List<GameObject>();
    [SerializeField] List<GameObject> WrongBtn = new List<GameObject>();

    [SerializeField] string scene;

    public AudioSource[] audioSource;
    

    //1
    public void firstClicked()
    {
        //���� �̹���, ���� ��ư �Ⱥ��̰�
        Gb[0].SetActive(false);
        Btn[0].SetActive(false);
        WrongBtn[0].SetActive(false);

        //�������Ұ�� ��ư, �Ÿ޴�ī�װ� ȭ�� ���̰�
        Gb[1].SetActive(true);
        Btn[1].SetActive(true);
        WrongBtn[1].SetActive(true);
        WrongBtn[2].SetActive(true);
        WrongBtn[3].SetActive(true);
    }

    //2
    public void secondClicked()
    {
        //�������Ұ�� ��ư, �Ÿ޴�ī�װ� ȭ�� ���̰�
        Gb[1].SetActive(false);
        Btn[1].SetActive(false);
        WrongBtn[1].SetActive(false);
        WrongBtn[2].SetActive(false);
        WrongBtn[3].SetActive(false);

        //��Ʈor��ǰ ���� ��ư, ��Ʈor��ǰ �̹��� ȭ�� ����
        Gb[2].SetActive(true);
        Btn[2].SetActive(true);

        WrongBtn[4].SetActive(true);

    }

    //3
    public void thirdClicked()
    {
        //��Ʈor��ǰ ���� ��ư, ��Ʈor��ǰ �̹��� ȭ�� ����
        Gb[2].SetActive(false);
        Btn[2].SetActive(false);

        WrongBtn[4].SetActive(false);


        //��Ʈ ����(����, ���̵�޴�, ��û����) ��ư, ��Ʈ ���� �̹��� ȭ�� ����
        Gb[3].SetActive(true);
        Btn[3].SetActive(true);
        Btn[4].SetActive(true);
        Btn[5].SetActive(true);

        WrongBtn[5].SetActive(true);
        WrongBtn[6].SetActive(true);
        WrongBtn[7].SetActive(true);

    }

    //4 -> �ٸ� ��ũ��Ʈ(CokeClick, NextPage���� ����, �� �־ ��
    public void fourthClicked()
    {
        //��Ʈ ����(����, ���̵�޴�, ��û����) ��ư, ��Ʈ ���� �̹��� ȭ�� ������,
        Gb[3].SetActive(false);

        Btn[3].SetActive(false);
        Btn[4].SetActive(false);
        Btn[5].SetActive(false);

        WrongBtn[5].SetActive(false);
        WrongBtn[6].SetActive(false);
        WrongBtn[7].SetActive(false);
        //ġŲ ī�װ� �̹���, ġŲ Ŭ�� ��ư �ܺ��Լ����� ȣ��

        WrongBtn[8].SetActive(true);
    }

    //5
    public void fifthClicked() //����Ȯ�� ��ư
    {
        Gb[4].SetActive(false);
        Btn[6].SetActive(false);
        WrongBtn[8].SetActive(false);


        Gb[5].SetActive(true);
        Btn[7].SetActive(true);
        WrongBtn[9].SetActive(true);
        WrongBtn[10].SetActive(true);

    }

    //5_1 ����ſ�ī�� ��ư
    public void fifth_1Clicked()
    {
        Btn[9].SetActive(true);
        Btn[8].SetActive(true);

        Btn[7].SetActive(false);
    }

    //�����ϱ� ��ư
    public void sixth_2Clicked()
    {
        Btn[8].SetActive(false);
        Btn[9].SetActive(false);


        Gb[5].SetActive(false);

        Gb[6].SetActive(true);
    }

    public void LoadingScene()
    {
        SceneManager.LoadScene(scene);
    }
}

