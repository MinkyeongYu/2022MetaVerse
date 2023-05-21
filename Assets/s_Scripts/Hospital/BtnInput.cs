using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class BtnInput : MonoBehaviour
{
    public InputField f;
    public static string BtnName ="";

    public void GetButtonName()
    {
        BtnName = EventSystem.current.currentSelectedGameObject.name;
        f.text += BtnName;
    }
}
