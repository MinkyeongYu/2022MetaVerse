using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OpenMenu : MonoBehaviour
{

    public GameObject optionMenu;
    public GameObject closeBtn;

    //public void OnPointerDown(PointerEventData eventData)
    //{
    //    isBtnDown = true;
    //}

    //public void OnPointerUp(PointerEventData eventData)
    //{
    //    isBtnDown = false;
    //}

    public void Open()
    {

        optionMenu.SetActive(true);
        closeBtn.SetActive(true);
        /*if (isBtnDown)
        {
            optionBtn.SetActive(false);
            optionMenu.SetActive(true);
            closeBtn.SetActive(true);
        }*/
    }
}