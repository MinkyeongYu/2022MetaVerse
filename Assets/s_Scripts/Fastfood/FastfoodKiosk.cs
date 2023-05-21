using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FastfoodKiosk : MonoBehaviour
{
    [SerializeField] List<GameObject> Gb = new List<GameObject>();
    [SerializeField] List<GameObject> Btn = new List<GameObject>();
    [SerializeField] string scene;

    public AudioSource[] audioSource;
    public GameObject sound;


    /* �̹��� ����
        0 :     ���� vs ����
        1 :     �Ÿ޴�
        2 :     ��ǰ vs ��Ʈ
        3 :     ��Ʈ ���̵�޴� ����
        4 :     �ֹ� �� ���� ���_�Ÿ޴� ī�װ�
        5 :     ġŲ ī�װ� �̵��� ȭ��
        6 :     �Ķ��̵� ġŲ ���õ� ȭ��
        7 :     ���� ���� ȭ��    (���� ���� (�ſ�ī��) --> �ſ�ī�� ��ư �� ����
                                   �����ϱ� ��ư ����)
        8 :     ī�� ���� ȭ��
        9 :     ī�� ���� �Ϸ� ȭ��
        10:     ������ ȭ��
    */

    //1
    public void firstClicked()
    {
        //���� �̹���, ���� ��ư �Ⱥ��̰�
        Gb[0].SetActive(false);
        Btn[0].SetActive(false);
        sound.SetActive(false);

        //�Ÿ޴� ī�װ�����~
        audioSource[0].Play();

        //��Ÿ���� ��ư, �Ÿ޴�ī�װ� ȭ�� ���̰�
        Gb[1].SetActive(true);
        Btn[1].SetActive(true);
    }

    //2
    public void secondClicked()
    {
        //��Ÿ���� ��ư, �Ÿ޴�ī�װ� ȭ�� ����
        Gb[1].SetActive(false);
        Btn[1].SetActive(false);
        sound.SetActive(false);

        //��Ʈor��ǰ ���� ��ư, ��Ʈor��ǰ �̹��� ȭ�� ����
        Gb[2].SetActive(true);
        Btn[2].SetActive(true);
    }

    //3
    public void thirdClicked()
    {
        //��Ʈor��ǰ ���� ��ư, ��Ʈor��ǰ �̹��� ȭ�� ����
        Gb[2].SetActive(false);
        Btn[2].SetActive(false);
        sound.SetActive(false);

        //���̵� �޴��� ~
        audioSource[1].Play();

        //��Ʈ ����(����, ���̵�޴�, ��û����) ��ư, ��Ʈ ���� �̹��� ȭ�� ����
        Gb[3].SetActive(true);
        Btn[3].SetActive(true);
        Btn[4].SetActive(true);
        Btn[5].SetActive(true);
    }

    //4 -> �ٸ� ��ũ��Ʈ(CokeClick, NextPage���� ����, �� �־ ��
    public void fourthClicked() 
    {
        //��Ʈ ����(����, ���̵�޴�, ��û����) ��ư, ��Ʈ ���� �̹��� ȭ�� ������,
        Gb[3].SetActive(false);

        Btn[3].SetActive(false);
        Btn[4].SetActive(false);
        Btn[5].SetActive(false);

        //ġŲ ī�װ��� ~
        audioSource[2].Play();

        //ġŲ ī�װ� �̹���, ġŲ Ŭ�� ��ư �ܺ��Լ����� ȣ��

    }

    //5
    public void fifthClicked() //ġŲ ī�װ� ������ ��
    {
        Gb[4].SetActive(false);

        Btn[6].SetActive(false);


        Gb[5].SetActive(true);
        Btn[7].SetActive(true);
        //Btn[11].SetActive(true);
    }

    //5_1
    public void fifth_1Clicked()
    {
        Gb[5].SetActive(false);
        Btn[7].SetActive(false);

        //����Ȯ�ι�ư �����ּ���.
        audioSource[3].Play();

        Gb[6].SetActive(true);
        Btn[8].SetActive(true);
        
    }

    //5_2
    public void fifth_2Clicked()
    {
        Gb[6].SetActive(false);
        Btn[8].SetActive(false);

        //��Ƴ��� �޴� ���� ȭ��
        audioSource[4].Play();


        Gb[7].SetActive(true);
        Btn[11].SetActive(true);

    }

    //6
    public void sixthClicked()
    {
        Btn[11].SetActive(false);

        //����Ȯ�� ��ư�� �����ּ���.
        audioSource[5].Play();

        Btn[9].SetActive(true);
        Btn[10].SetActive(true);

    }

    public void sixth_2Clicked()
    {
        Btn[9].SetActive(false);
        Btn[10].SetActive(false);
        Gb[7].SetActive(false);
        
        //ī�带 ����~
        audioSource[6].Play();

        Gb[8].SetActive(true);
    }

    public void LoadingScene()
    {
        SceneManager.LoadScene(scene);
    }
}
