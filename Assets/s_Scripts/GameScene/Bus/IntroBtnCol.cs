using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroBtnCol : MonoBehaviour
{
    public static bool IntroBtn1 = false;
    public static bool IntroBtn2 = false;
    public static bool IntroBtn3 = false;

    public void BtnCol()
    {
        IntroBtn1 = true;
    }
    
    public void KFC_BtnCol()
    {
        IntroBtn2 = true;
    }

    public void Hospital_BtnCol()
    {
        IntroBtn3 = true;
    }
}
