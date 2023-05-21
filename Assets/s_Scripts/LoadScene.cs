using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [SerializeField] string scene;

    public void LoadingScene()
    {
        SceneManager.LoadScene(scene);
    }
}
