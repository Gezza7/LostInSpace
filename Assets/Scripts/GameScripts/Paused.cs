using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paused : MonoBehaviour
{
    GameObject[] gameObjects;
    private GameObject[] pauseObjects;

    void Start(){
        Time.timeScale = 1;
        pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
        hidePaused();
    }//Void Start

    // Update is called once per frame
    void Update(){//pauses game with 'P'
        if (Input.GetKeyDown(KeyCode.P)){
            if (Time.timeScale == 1){
                Time.timeScale = 0;
                showPaused();
            }//nestled if
            else if (Time.timeScale == 0){
                Debug.Log("High");
                Time.timeScale = 1;
                hidePaused();
            }//nestled else
        }//if
    }//Void update
    public void Reload(){//reloads level
        Application.LoadLevel(Application.loadedLevel);
    }//Void reload
    public void pauseControl(){//pauses the screen
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            showPaused();
        }//if
        else if (Time.timeScale == 0){
            Time.timeScale = 1;
            hidePaused();
        }//else
    }//void pause control
    
    public void showPaused(){//show objects tagged with "showPaused"
        foreach(GameObject g in pauseObjects){
            g.SetActive(true);
        }//foreach
    }//void showPaused
    public void hidePaused(){//hides objects tagged with ShowOnPause
        foreach (GameObject g in pauseObjects){
            g.SetActive(false);
        }//foreach
    }//void hidePauesd
    
    public void LoadLevel(string level){//loads level
        Application.LoadLevel(level);
    }//load level
}//public class