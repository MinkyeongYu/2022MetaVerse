using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ForBackspace : MonoBehaviour, IPointerDownHandler
{
    public InputField Txt;
    public Text _text;
    public static int deleteOn=0;


    public void OnPointerDown(PointerEventData eventData)
    {
        deleteOn += 1;
    }
}
