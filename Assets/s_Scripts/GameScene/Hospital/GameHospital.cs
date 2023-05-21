using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;
using UnityEngine.SceneManagement;

public class GameHospital : MonoBehaviour
{
    [SerializeField] List<GameObject> Gb = new List<GameObject>();
    [SerializeField] List<GameObject> Btn = new List<GameObject>();
    [SerializeField] List<GameObject> WrongBtn = new List<GameObject>();

    [SerializeField] string scene;

    public GameObject[] KeyPad;
    public AudioSource[] audioSource;
    public /*TextMeshProUGUI*/InputField Txt;
    public Text _text;

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
        WrongBtn[0].SetActive(false);
        WrongBtn[1].SetActive(false);

        for (int i = 0; i < KeyPad.Length; i++)
        {
            KeyPad[i].SetActive(true);
        }


        Gb[1].SetActive(true);
        Btn[1].SetActive(true);
        Btn[2].SetActive(true);
        Btn[3].SetActive(true);
        Btn[4].SetActive(true);

    }

    //정정 버튼을 눌렀을 때 text 모두 지움, 2
    public void Cancel()
    {
        if (_text.text != "" || Txt.text != "")
        {
            Txt.text = "";
            _text.text = "";
        }
    }

    //확인버튼을 눌렀을 때 toggle이 true인 상태라면 다음 이미지로 전환, 2
    public void secondClicked()
    {
        if (Btn[1].GetComponent<Toggle>().isOn == true && Txt.text == "1810161")
        {
            Gb[1].SetActive(false);
            Btn[1].SetActive(false);
            Btn[2].SetActive(false);
            Btn[3].SetActive(false);
            Btn[4].SetActive(false);

            Gb[2].SetActive(true);
            Btn[5].SetActive(true);

            for (int i = 0; i < KeyPad.Length; i++)
            {
                KeyPad[i].SetActive(false);
            }
            Txt.text = "";
            _text.text = "";

        }

    }

    // 3, 돌아가기 버튼
    public void backClick()
    {
        Gb[2].SetActive(false);
        Btn[5].SetActive(false);
        Gb[3].SetActive(true);
        Btn[6].SetActive(true);

        WrongBtn[2].SetActive(true);
        WrongBtn[1].SetActive(true);
    }
    // 4, 수남 및 처방전 발행 버튼
    public void fourthClicked()
    {
        Gb[3].SetActive(false);
        Btn[6].SetActive(false);

        WrongBtn[2].SetActive(false);
        WrongBtn[1].SetActive(false);

        for (int i = 0; i < KeyPad.Length; i++)
        {
            KeyPad[i].SetActive(true);
        }
        Gb[4].SetActive(true);
        Btn[7].SetActive(true);
        Btn[8].SetActive(true);
        Btn[9].SetActive(true);

    }

    // 5, 정정, 확인, 진료카드번호 입력 (재탕)
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
        if (Btn[1].GetComponent<Toggle>().isOn == true && Txt.text == "1810161")
        {
            Gb[4].SetActive(false);
            Btn[7].SetActive(false);
            Btn[8].SetActive(false);
            Btn[9].SetActive(false);

            Gb[6].SetActive(true);
            Btn[10].SetActive(true);
            Btn[11].SetActive(true);

            for (int i = 0; i < KeyPad.Length; i++)
            {
                KeyPad[i].SetActive(false);
            }

        }

    }

    // 6, 수납 여부 체크된 상태에서 일시불 버튼 클릭되면 다음 화면 전환
    public void SixthClicked()
    {
        if (Btn[10].GetComponent<Toggle>().isOn == true)
        {
            Gb[6].SetActive(false);
            Btn[10].SetActive(false);
            Btn[11].SetActive(false);

            for (int i = 0; i < KeyPad.Length; i++)
            {
                KeyPad[i].SetActive(false);
            }

            Gb[7].SetActive(true);
            Btn[12].SetActive(true);


        }
    }


    // 7, 카드가 삽입된 상태에서 버튼이 클릭되면 다음 화면 전환
    public void seventhClicked()
    {
        if (SingletonCard.isCard == true)
        {
            Gb[7].SetActive(false);
            Btn[12].SetActive(false);

            Gb[8].SetActive(true);
        }
    }

    //8, 9번째 이미지로 넘어갈때 코루틴 사용해서 3초 후 넘어가게 하기=>Hospital3Sec 스크립트 이용 (결제중)



    //9. 코루틴을 이용해서 5초 후 10번째 이미지로 변환되게 하기, 확인 버튼 활성화 => 다른 스크립트 이용

    //마지막으로, 확인을 누르면 마을로 돌아가라는 오디오가 나오고, 마을로 돌아가는 버튼 활성화됨
    public void confirm3()
    {
        Btn[14].SetActive(true);
        audioSource[0].Play();
    }

    //마을로 돌아가는 버튼 눌렀을때, 마을로 씬 전환
    public void LoadingScene()
    {
        SceneManager.LoadScene(scene);
    }

}

