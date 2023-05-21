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
        //시작 이미지, 포장 버튼 안보이게
        Gb[0].SetActive(false);
        Btn[0].SetActive(false);
        WrongBtn[0].SetActive(false);

        //더블더블불고기 버튼, 신메뉴카테고리 화면 보이게
        Gb[1].SetActive(true);
        Btn[1].SetActive(true);
        WrongBtn[1].SetActive(true);
        WrongBtn[2].SetActive(true);
        WrongBtn[3].SetActive(true);
    }

    //2
    public void secondClicked()
    {
        //더블더블불고기 버튼, 신메뉴카테고리 화면 보이게
        Gb[1].SetActive(false);
        Btn[1].SetActive(false);
        WrongBtn[1].SetActive(false);
        WrongBtn[2].SetActive(false);
        WrongBtn[3].SetActive(false);

        //세트or단품 선택 버튼, 세트or단품 이미지 화면 켜짐
        Gb[2].SetActive(true);
        Btn[2].SetActive(true);

        WrongBtn[4].SetActive(true);

    }

    //3
    public void thirdClicked()
    {
        //세트or단품 선택 버튼, 세트or단품 이미지 화면 꺼짐
        Gb[2].SetActive(false);
        Btn[2].SetActive(false);

        WrongBtn[4].SetActive(false);


        //세트 선택(음료, 사이드메뉴, 요청사항) 버튼, 세트 선택 이미지 화면 켜짐
        Gb[3].SetActive(true);
        Btn[3].SetActive(true);
        Btn[4].SetActive(true);
        Btn[5].SetActive(true);

        WrongBtn[5].SetActive(true);
        WrongBtn[6].SetActive(true);
        WrongBtn[7].SetActive(true);

    }

    //4 -> 다른 스크립트(CokeClick, NextPage에서 구현, 안 넣어도 됨
    public void fourthClicked()
    {
        //세트 선택(음료, 사이드메뉴, 요청사항) 버튼, 세트 선택 이미지 화면 꺼지고,
        Gb[3].SetActive(false);

        Btn[3].SetActive(false);
        Btn[4].SetActive(false);
        Btn[5].SetActive(false);

        WrongBtn[5].SetActive(false);
        WrongBtn[6].SetActive(false);
        WrongBtn[7].SetActive(false);
        //치킨 카테고리 이미지, 치킨 클릭 버튼 외부함수에서 호출

        WrongBtn[8].SetActive(true);
    }

    //5
    public void fifthClicked() //결제확인 버튼
    {
        Gb[4].SetActive(false);
        Btn[6].SetActive(false);
        WrongBtn[8].SetActive(false);


        Gb[5].SetActive(true);
        Btn[7].SetActive(true);
        WrongBtn[9].SetActive(true);
        WrongBtn[10].SetActive(true);

    }

    //5_1 투명신용카드 버튼
    public void fifth_1Clicked()
    {
        Btn[9].SetActive(true);
        Btn[8].SetActive(true);

        Btn[7].SetActive(false);
    }

    //결제하기 버튼
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

