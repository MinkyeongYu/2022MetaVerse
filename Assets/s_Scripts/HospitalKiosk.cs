using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;
using UnityEngine.SceneManagement;

public class HospitalKiosk : MonoBehaviour
{
    [SerializeField] List<GameObject> Gb = new List<GameObject>();
    [SerializeField] List<GameObject> Btn = new List<GameObject>();
    [SerializeField] string scene;

    public GameObject[] KeyPad;
    public AudioSource[] audioSource;
    public /*TextMeshProUGUI*/InputField Txt;
    public Text _text;
    public GameObject sound;

    int key = 0;

    //void Start()
    //{
    //    Txt= GetComponent<TextMeshProUGUI>();
    //}

    // 1
    public void firstClicked()
    {
        Gb[0].SetActive(false);
        Btn[0].SetActive(false);
        
        for(int i=0; i<KeyPad.Length; i++)
        {
            KeyPad[i].SetActive(true);
        }
        audioSource[0].Play();
        sound.SetActive(false);


        Gb[1].SetActive(true);
        Btn[1].SetActive(true);
        Btn[2].SetActive(true);
        Btn[3].SetActive(true);
        Btn[4].SetActive(true);
     
    }
    ////Ű�е�� ���� �Է�
    //public void KeyPlus1()
    //{
    //    key = 1;
    //    Txt.text = key.ToString();
    //}
    //public void KeyPlus2()
    //{
    //    key = 2;
    //    Txt.text = key.ToString();
    //}
    //public void KeyPlus3()
    //{
    //    key = 3;
    //    Txt.text = key.ToString();
    //}
    //public void KeyPlus4()
    //{
    //    key = 4;
    //    Txt.text = key.ToString();
    //}
    //public void KeyPlus5()
    //{
    //    key = 5;
    //    Txt.text = key.ToString();
    //}
    //public void KeyPlus6()
    //{
    //    key = 6;
    //    Txt.text=key.ToString();
    //}
    //public void KeyPlus7()
    //{
    //    key = 7;
    //    Txt.text=key.ToString();
    //}
    //public void KeyPlus8()
    //{
    //    key = 8;
    //    Txt.text=key.ToString();
    //}
    //public void KeyPlus9()
    //{
    //    key = 9;
    //    Txt.text=key.ToString();    
    //}
    //public void KeyPlus10()
    //{
    //    key = 10;
    //    Txt.text=key.ToString();
    //}

    //���� ��ư�� ������ �� text ��� ����, 2
    public void Cancel()
    {
        if (_text.text != "" || Txt.text!="")
        {
            Txt.text = "";
            _text.text = "";
        }
    }

    //Ȯ�ι�ư�� ������ �� toggle�� true�� ���¶�� ���� �̹����� ��ȯ, 2
    public void secondClicked()
    {
        if(Btn[1].GetComponent<Toggle>().isOn == true && Txt.text=="6583762")
        {
            Gb[1].SetActive(false);
            Btn[1].SetActive(false);
            Btn[2].SetActive(false);
            Btn[3].SetActive(false);
            Btn[4].SetActive(false);

            Gb[2].SetActive(true);
            Btn[5].SetActive(true);
            
            for(int i=0; i<KeyPad.Length; i++)
            {
                KeyPad[i].SetActive(false);
            }
            Txt.text = "";
            _text.text = "";
            audioSource[2].Play();

        }

    }

    // 3, ���ư��� ��ư
    public void backClick()
    {
        Gb[2].SetActive(false);
        Btn[5].SetActive(false);
        Gb[3].SetActive(true);
        Btn[6].SetActive(true);
        audioSource[3].Play();
    }
    // 4, ���� �� ó���� ���� ��ư
    public void fourthClicked()
    {
        Gb[3].SetActive(false);
        Btn[6].SetActive(false);

        for(int i=0; i<KeyPad.Length; i++)
        {
            KeyPad[i].SetActive(true);
        }
        Gb[4].SetActive(true);
        Btn[7].SetActive(true);
        Btn[8].SetActive(true);
        Btn[9].SetActive(true);
        audioSource[4].Play();

    }

    // 5, ����, Ȯ��, ����ī���ȣ �Է� (����)
    //for Cancel2 Button
    public void Cancel2()
    {
        if (_text.text != null)
        {
            Txt.text = "";
        }
    }

    //for Confirm2 Button
    public void fifthClicked()
    {
        if (Btn[1].GetComponent<Toggle>().isOn == true && Txt.text == "6583762")
        {
            Gb[4].SetActive(false);
            Btn[7].SetActive(false);
            Btn[8].SetActive(false);
            Btn[9].SetActive(false);

            Gb[6].SetActive(true);
            Btn[10].SetActive(true);
            Btn[11].SetActive(true);
            audioSource[5].Play();

            for (int i = 0; i < KeyPad.Length; i++)
            {
                KeyPad[i].SetActive(false);
            }

        }

    }

    // 6, ���� ���� üũ�� ���¿��� �Ͻú� ��ư Ŭ���Ǹ� ���� ȭ�� ��ȯ
    public void SixthClicked()
    {
        if(Btn[10].GetComponent<Toggle>().isOn == true)
        {
            Gb[6].SetActive(false);
            Btn[10].SetActive(false);
            Btn[11].SetActive(false);

            for(int i=0; i< KeyPad.Length; i++)
            {
                KeyPad[i].SetActive(false);
            }
            
            Gb[7].SetActive(true);
            Btn[12].SetActive(true);
            //ī�带 ���Ա��� �־��ּ���
            audioSource[6].Play();


        }
    }


    // 7, ī�尡 ���Ե� ���¿��� ��ư�� Ŭ���Ǹ� ���� ȭ�� ��ȯ
    public void seventhClicked()
    {
        if (SingletonCard.isCard == true)
        {
            Gb[7].SetActive(false);
            Btn[12].SetActive(false);

            Gb[8].SetActive(true);
            audioSource[7].Play();
        }
    }

    //8, 9��° �̹����� �Ѿ�� �ڷ�ƾ ����ؼ� 3�� �� �Ѿ�� �ϱ�=>Hospital3Sec ��ũ��Ʈ �̿� (������)
    


    //9. �ڷ�ƾ�� �̿��ؼ� 5�� �� 10��° �̹����� ��ȯ�ǰ� �ϱ�, Ȯ�� ��ư Ȱ��ȭ => �ٸ� ��ũ��Ʈ �̿�

    //����������, Ȯ���� ������ ������ ���ư���� ������� ������, ������ ���ư��� ��ư Ȱ��ȭ��
    public void confirm3()
    {
        audioSource[9].Play();
        Btn[14].SetActive(true);
    }

    //������ ���ư��� ��ư ��������, ������ �� ��ȯ
    public void LoadingScene()
    {
        SceneManager.LoadScene(scene);
    }

}
