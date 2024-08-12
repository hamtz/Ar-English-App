using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeScript : MonoBehaviour
{
    public void StartAr()
    {
        SceneManager.LoadScene("ScanArScene");
    }

    public void StartAbout()
    {
        SceneManager.LoadScene("AboutScene");
    }

    public void QuitApp()
    {
        Application.Quit();
        Debug.Log("App Closed");

    }
}
