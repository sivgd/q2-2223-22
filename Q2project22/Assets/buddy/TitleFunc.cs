using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleFunc : MonoBehaviour
{
    public void exit()
    {
        Debug.Log("If you arrre seeing this, the the application should quit. if the application has not quit, contact your local Unity Expert here: +45 33 92 00 00");
        Application.Quit();
    }

    public void Credits()
    {
        Debug.Log("cremdit");
        SceneManager.LoadScene("credits");
    }

    public void ReadThis()
    {
        Debug.Log("controll");
        SceneManager.LoadScene("controls");
    }

    public void Game()
    {
        Debug.Log("start!");
        SceneManager.LoadScene("MainScene");
    }

    public void title()
    {
        Debug.Log("timtle");
        SceneManager.LoadScene(0);
    }
}
