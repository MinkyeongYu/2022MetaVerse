using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CloseMenu : MonoBehaviour, IPointerDownHandler
{
    public GameObject optionMenu;
    public GameObject closeBtn;

    private void Start()
    {
        closeBtn.GetComponent<Toggle>().isOn = false;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        closeBtn.GetComponent<Toggle>().isOn = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        closeBtn.GetComponent<Toggle>().isOn = false;
    }

    public void Close()
    {
        if (closeBtn.GetComponent<Toggle>().isOn == true)
        {
            optionMenu.SetActive(false);
            closeBtn.SetActive(false);
            closeBtn.GetComponent<Toggle>().isOn = false;
        }
    }
}