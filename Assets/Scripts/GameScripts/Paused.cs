using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Paused : MonoBehaviour
{
    GameObject[] gameObjects;
    private GameObject[] pauseObjects;

    void Start()
    {
        Time.timeScale = 1;
        pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
        hidePausedScreen();
    }//Void Start

    // Update is called once per frame
    void Update()
    {//pauses game with 'P'
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                ShowPausedScreen();
            }//nestled if
            else if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
                hidePausedScreen();
            }//nestled else
        }//if
    }//Void update
    public void pauseControl()
    {//pauses the screen
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            ShowPausedScreen();
        }//if
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            hidePausedScreen();
        }//else
    }//void pause control
    public void Reload()
    {//reloads level
        SceneManager.LoadScene(1);
    }//Void reload
    public void LoadMenu(string level)
    {//loads main menu
        SceneManager.LoadScene(0);
    }//loadMenu
    public void ShowPausedScreen()
    {//show objects tagged with "showPaused"
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(true);
        }//foreach
    }//void showPaused
    public void hidePausedScreen()
    {//hides objects tagged with ShowOnPause
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(false);
        }//foreach
    }//void hidePauesd
}//public class