using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;
using UnityEngine.SceneManagement;

public class InputFieldActivate : MonoBehaviour
{
    string txt;
    public InputField text;
    public Text _text;

    void Start()
    {
        txt = GetComponent<InputField>().text;
        txt = "";
        text.text = txt;
        _text.text = txt;
    }
    
    void Update()
    {
        if (ForBackspace.deleteOn > 0)
        {
            for(int i=0; i <= ForBackspace.deleteOn; i++)
            {
                txt = txt.Remove(1);
                text.text = txt;
                _text.text = txt;
            }
            
        }
    }
}
