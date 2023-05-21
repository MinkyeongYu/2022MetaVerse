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

        //부산해운대 눌러~
        audioSource[0].Play();

        //부산해운대 버튼, 목적지 선택 이미지 활성화
        Gb[1].SetActive(true);
        Btn[1].SetActive(true);

    }
   


    //2, 부산해운대를 목적지로 눌렀을 때
    public void secondClicked()
    {
        Gb[1].SetActive(false);
        Btn[1].SetActive(false);
        //시간선택이미지
        Gb[2].SetActive(true);
        //13:30분 버스를 선택~
        audioSource[1].Play();
        //시간선택버튼
        Btn[2].SetActive(true);
    }

    // 3, 13:30분 버스를 선택하면, 선택된 화면 나옴
    public void thirdClicked()
    {
        Gb[2].SetActive(false);
        Btn[2].SetActive(false);
        //선택된 화면 활성화
        Gb[3].SetActive(true);
        //모든게 완료가 되었으면 진행을 눌러주세요
        audioSource[2].Play();
        //진행버튼 활성화
        Btn[3].SetActive(true);
    }
    // 4, 진행버튼을 누르면, 좌석 선택 화면 활성화
    public void fourthClicked()
    {
        Gb[3].SetActive(false);
        Btn[3].SetActive(false);

        //좌석 선택 이미지
        Gb[4].SetActive(true);
        //25번 좌석을 눌러주세요
        audioSource[3].Play();
        //25번 좌석 버튼 
        Btn[4].SetActive(true);
    }


    // 5, 25번 좌석을 선택하면, 25번 승차권 정보 활성화
    public void fifthClicked()
    {
        Btn[4].SetActive(false);
        //좌석 선택 이미지
        Gb[5].SetActive(true);
        //좌석 선택이 완료되었으면 확인을 눌러주세요
        audioSource[4].Play();
        // 확인버튼
        Btn[5].SetActive(true);
    }

    // 6, 확인버튼을 누르면, 
    public void SixthClicked()
    {
        Gb[5].SetActive(false);
        Btn[5].SetActive(false);

        //카드 삽입 이미지
        Gb[6].SetActive(true);
        //카드를 넣어주세요
        audioSource[5].Play();


        ////아래부분은 다른 스크립트에 적용 (이미지)
        ////카드를 삽입하면
        //if (SingletonCard2.isCardOn == true)
        //{
        //    Gb[6].SetActive(false);

        //    //카드빼라는 이미지
        //    Gb[7].SetActive(true);
        //    //카드를 빼주세요
        //    audioSource[6].Play();
        //}
    }


    //// 7, 카드빼면 발권진행.. 코루틴, 다른 스크립트에 적용 (이미지)
    //public void seventhClicked()
    //{
    //    if (SingletonCard2.isCardOn == false)
    //    {
    //        Gb[7].SetActive(false);
    //        Gb[8].SetActive(true);
    //        audioSource[7].Play();

    //    }
    //}
    //마을로 돌아가는 버튼 눌렀을때, 마을로 씬 전환
    public void LoadingScene()
    {
        SceneManager.LoadScene(scene);
    }

}
