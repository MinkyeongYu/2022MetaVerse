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


    /* 이미지 정리
        0 :     포장 vs 매장
        1 :     신메뉴
        2 :     단품 vs 세트
        3 :     세트 사이드메뉴 선택
        4 :     주문 상세 내역 출력_신메뉴 카테고리
        5 :     치킨 카테고리 이동된 화면
        6 :     후라이드 치킨 선택된 화면
        7 :     결제 선택 화면    (결제 선택 (신용카드) --> 신용카드 버튼 색 변경
                                   결제하기 버튼 선택)
        8 :     카드 결제 화면
        9 :     카드 결제 완료 화면
        10:     마무리 화면
    */

    //1
    public void firstClicked()
    {
        //시작 이미지, 포장 버튼 안보이게
        Gb[0].SetActive(false);
        Btn[0].SetActive(false);
        sound.SetActive(false);

        //신메뉴 카테고리에서~
        audioSource[0].Play();

        //메타버거 버튼, 신메뉴카테고리 화면 보이게
        Gb[1].SetActive(true);
        Btn[1].SetActive(true);
    }

    //2
    public void secondClicked()
    {
        //메타버거 버튼, 신메뉴카테고리 화면 꺼짐
        Gb[1].SetActive(false);
        Btn[1].SetActive(false);
        sound.SetActive(false);

        //세트or단품 선택 버튼, 세트or단품 이미지 화면 켜짐
        Gb[2].SetActive(true);
        Btn[2].SetActive(true);
    }

    //3
    public void thirdClicked()
    {
        //세트or단품 선택 버튼, 세트or단품 이미지 화면 꺼짐
        Gb[2].SetActive(false);
        Btn[2].SetActive(false);
        sound.SetActive(false);

        //사이드 메뉴는 ~
        audioSource[1].Play();

        //세트 선택(음료, 사이드메뉴, 요청사항) 버튼, 세트 선택 이미지 화면 켜짐
        Gb[3].SetActive(true);
        Btn[3].SetActive(true);
        Btn[4].SetActive(true);
        Btn[5].SetActive(true);
    }

    //4 -> 다른 스크립트(CokeClick, NextPage에서 구현, 안 넣어도 됨
    public void fourthClicked() 
    {
        //세트 선택(음료, 사이드메뉴, 요청사항) 버튼, 세트 선택 이미지 화면 꺼지고,
        Gb[3].SetActive(false);

        Btn[3].SetActive(false);
        Btn[4].SetActive(false);
        Btn[5].SetActive(false);

        //치킨 카테고리로 ~
        audioSource[2].Play();

        //치킨 카테고리 이미지, 치킨 클릭 버튼 외부함수에서 호출

    }

    //5
    public void fifthClicked() //치킨 카테고리 눌렀을 때
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

        //결제확인버튼 눌러주세요.
        audioSource[3].Play();

        Gb[6].SetActive(true);
        Btn[8].SetActive(true);
        
    }

    //5_2
    public void fifth_2Clicked()
    {
        Gb[6].SetActive(false);
        Btn[8].SetActive(false);

        //담아놓은 메뉴 결제 화면
        audioSource[4].Play();


        Gb[7].SetActive(true);
        Btn[11].SetActive(true);

    }

    //6
    public void sixthClicked()
    {
        Btn[11].SetActive(false);

        //결제확인 버튼을 눌러주세요.
        audioSource[5].Play();

        Btn[9].SetActive(true);
        Btn[10].SetActive(true);

    }

    public void sixth_2Clicked()
    {
        Btn[9].SetActive(false);
        Btn[10].SetActive(false);
        Gb[7].SetActive(false);
        
        //카드를 삽입~
        audioSource[6].Play();

        Gb[8].SetActive(true);
    }

    public void LoadingScene()
    {
        SceneManager.LoadScene(scene);
    }
}
