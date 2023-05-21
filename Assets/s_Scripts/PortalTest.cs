using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PortalTest : MonoBehaviour
{
    [SerializeField] string sceneName1;

    //public Image LoadingImage;

    private void OnTriggerEnter(Collider other)
    {

        SceneManager.LoadScene(sceneName1);
    }
}