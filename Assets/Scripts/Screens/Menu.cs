using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PressPlayButton()//When player presses "play", loads game scene
    {
        SceneManager.LoadScene(1);
    }
    public void PressQuitButton()//When player presses "quit", quits game
    {
        Application.Quit();
    }
}
