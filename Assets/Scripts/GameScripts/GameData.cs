using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    public static GameData Instance;

    public int score;
    public int enemiesKilled;
    public int waveNumber;
    public int nebulaShards;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            Debug.Log("DataManager created and set as singleton.");
        }
        else
        {
            Debug.Log("Duplicate DataManager found. Destroying the duplicate.");
            Destroy(gameObject);
        }

    }
    
    public int getScore()
    {
        return score;
    }
    public int getWave()
    {
        return waveNumber;
    }
    public int getKills()
    {
        return enemiesKilled;
    }
    public int getShards()
    {
        nebulaShards = ((waveNumber * 5) + ((score / 50) - enemiesKilled));
        return nebulaShards;
    }
}
