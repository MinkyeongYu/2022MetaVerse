using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardOff3 : MonoBehaviour
{
    public GameObject g8;

    void Update()
    {
        if (SingletonCard4.isCardOn3 == false)
        {

            g8.SetActive(true);

        }
    }
}
