using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStats : MonoBehaviour
{
    private GameData gameData;
    public void ReplayPressed()//Replay Level
    {
        SceneManager.LoadScene(1);
    }
    public void MainMenuPressed()//to Menu
    {
        SceneManager.LoadScene(0);
    }
}
