using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    GameObject[] gameObjects;
    private GameObject[] DeadPlayer;

    void Start()
    {

    }//Void Start

    // Update is called once per frame
    void Update()
    {

    }//Void update

    public void whenDead()
    {//show objects tagged with "whenDead"
        foreach (GameObject g in DeadPlayer)
        {
            g.SetActive(true);
        }//foreach
    }//void whenDead

    public void notDead()
    {//hides objects tagged with PlayerDead
        foreach (GameObject g in DeadPlayer)
        {
            g.SetActive(false);
        }//foreach
    }//void notDead

    public void GameStats(string level)
    {//loads level
        SceneManager.LoadScene(3);
    }//load level

}//public class