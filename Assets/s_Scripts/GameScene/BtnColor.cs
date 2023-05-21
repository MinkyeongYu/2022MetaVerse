using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnColor : MonoBehaviour
{
    public Button button;
    public Button button2;
    public Button button3;

    // Update is called once per frame
    void Update()
    {
        //Bus
        if(IntroBtnCol.IntroBtn1==true)
        {
            ChangeColor();
        }
        //KFC
        if (IntroBtnCol.IntroBtn2 == true)
        {
            ChangeColor2();
        }
        //Hospital
        if (IntroBtnCol.IntroBtn3 == true)
        {
            ChangeColor3();
        }
    }

    void ChangeColor()
    {
        ColorBlock colB = button.colors;

        colB.normalColor = new Color(1f, 1f, 1f, 1f);

        button.colors = colB;
    }
    void ChangeColor2()
    {
        ColorBlock colB = button2.colors;

        colB.normalColor = new Color(1f, 1f, 1f, 1f);

        button2.colors = colB;
    }
    void ChangeColor3()
    {
        ColorBlock colB = button3.colors;

        colB.normalColor = new Color(1f, 1f, 1f, 1f);

        button3.colors = colB;
    }
}
