using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetfalseBtn : MonoBehaviour
{
    [SerializeField] List<GameObject> Btn = new List<GameObject>();

    public void SetTrue1()
    {
        for (int i = 0; i < 20; i++)
        {
            Btn[i].SetActive(true);
        }
    }

    public void SetFalse1()
    {
        for(int i=0; i<20; i++)
        {
            Btn[i].SetActive(false);
        }
    }
    
    public void SetTrue2()
    {
        for (int i = 20; i < 22; i++)
        {
            Btn[i].SetActive(true);
        }
    }

    public void SetFalse2()
    {
        for (int i = 20; i < 22; i++)
        {
            Btn[i].SetActive(false);         
        }
    }

    public void SetTrue3()
    {
        for (int i = 22; i < 41; i++)
        {
            Btn[i].SetActive(true);
        }
    }

    public void SetFalse3()
    {
        for (int i = 22; i < 41; i++)
        {
            Btn[i].SetActive(false);
        }
    }
}
