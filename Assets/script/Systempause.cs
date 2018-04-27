using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Systempause : MonoBehaviour {

    public static Systempause sysP;
    public void gotoStartGame()
    {
        SceneManager.LoadScene("start");
    }
    public void gotoPlayGame()
    {
        SceneManager.LoadScene("Maingame");
    }
    public void Exitprogram()
    {
        Application.Quit();
    }

}
