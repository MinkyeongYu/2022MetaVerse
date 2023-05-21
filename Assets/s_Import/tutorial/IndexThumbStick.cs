using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class IndexThumbStick : MonoBehaviour
{
    public static int spotInt = 0;
    /*
        Primary : 왼손
        Secondary : 오른손
     */
    public GameObject spot;
    public GameObject spot2;
    public GameObject spot3;
    Vector3 spotPos;
    Vector3 spotPos2;
    Vector3 spotPos3;
    int num = 0;

    public AudioSource[] audio;
    public GameObject[] rawImage;
    public GameObject closeBtn;
    public GameObject aud;
    Vector2 primaryAxis;
    Vector2 secondaryAxis;

    void Start()
    {
        spotPos = spot.transform.position;
        spotPos2 = spot2.transform.position;
        spotPos3 = spot3.transform.position;
    }
    void Update()
    {
        primaryAxis = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);
        secondaryAxis = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick);

        //왼손 Thmbstick
        if (OVRInput.Get(OVRInput.Touch.PrimaryThumbstick) && num == 0)
        {
            if ((primaryAxis.x > 0.0f)|| (primaryAxis.x < 0.0f)|| (primaryAxis.y > 0.0f)|| (primaryAxis.y > 0.0f))
            {
                audio[0].Play();
                rawImage[0].SetActive(false);
                rawImage[1].SetActive(true);
                num = 1;
            }
        }
        //오른손 Thumbstick
        if (OVRInput.Get(OVRInput.Touch.SecondaryThumbstick)&&num==1)
        {
            if (secondaryAxis.x > 0.0f)
            {
                aud.SetActive(false);
                audio[1].Play();
                rawImage[1].SetActive(false);
                rawImage[2].SetActive(true);
                num = 2;
            }
        }
        //왼손 중지 ( ** 물체 들었을때를 더 추가해야함 )
        if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger)&&num==2)
        {
            audio[1].Stop();
            audio[2].Play();
            rawImage[2].SetActive(false);
            rawImage[3].SetActive(true);
            num = 3;
        }
        //오른손 검지
        //if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        //{
        //    audio[2].Stop();
        //    audio[3].Play();
        //    rawImage[3].SetActive(false);
        //    rawImage[4].SetActive(true);
        //}
    }
    //오른손 검지로 UI 클릭
    public void SecondaryIndexTrigger()
    {
        if (num == 3)
        {
            audio[2].Stop();
            audio[3].Play();
            rawImage[3].SetActive(false);
            rawImage[4].SetActive(true);
            num = 4;
        }
    }
    //slider 움직였을때
    public void SliderMove()
    {
        audio[3].Stop();
        audio[4].Play();
        rawImage[4].SetActive(false);
    }
    //Toggle On (checkBox 눌렀을때)
    public void OnToggle()
    {
        if (closeBtn.GetComponent<Toggle>().isOn == true)
        {
            audio[4].Stop();
            audio[5].Play();
        }
    }
}
