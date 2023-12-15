using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{

    [SerializeField] private GameObject enemy = null;
    private int wavecounter = 1;
    private bool waveAlive = false;
    private GameObject[] enemies = new GameObject[5];
    [SerializeField] private float nextWaveDelay = 5.0f;
    private float counter = 0.0f;
    private bool movmentStop = false;
    private GameData gameData;
    private int enemiesKilled = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter -= Time.deltaTime;
        waveAlive = checkWave();
        if(waveAlive == false)
        {
            if(counter <= 0)
            {
                spawnNextWave();
                movmentStop = false;
            }
        }
        else
        {
            
            counter = nextWaveDelay;
        }
        if(movmentStop == false)
        {
            spawnMovment();
        }

    }

    void spawnNextWave()
    {
        if(wavecounter == 1)
        {
            GameObject enemy1 = Instantiate(enemy, new Vector2(0, 8.5f), Quaternion.identity);
            enemies[0] = enemy1;
            wavecounter++;
        }
        else if(wavecounter == 2)
        {
            GameObject enemy1 = Instantiate(enemy, new Vector2(-2.5f, 8.5f), Quaternion.identity);
            enemies[1] = enemy1;
            GameObject enemy2 = Instantiate(enemy, new Vector2(0, 8.5f), Quaternion.identity);
            enemies[0] = enemy2;
            GameObject enemy3 = Instantiate(enemy, new Vector2(2.5f, 8.5f), Quaternion.identity);
            enemies[2] = enemy3;
            wavecounter++;
            
        }
        else if(wavecounter > 2)
        {
            GameObject enemy1 = Instantiate(enemy, new Vector2(-5, 8.5f), Quaternion.identity);
            enemies[3] = enemy1;
            GameObject enemy2 = Instantiate(enemy, new Vector2(-2.5f, 8.5f), Quaternion.identity);
            enemies[1] = enemy2;
            GameObject enemy3 = Instantiate(enemy, new Vector2(0, 8.5f), Quaternion.identity);
            enemies[0] = enemy3;
            GameObject enemy4 = Instantiate(enemy, new Vector2(2.5f, 8.5f), Quaternion.identity);
            enemies[2] = enemy4;
            GameObject enemy5 = Instantiate(enemy, new Vector2(5, 8.5f), Quaternion.identity);
            enemies[4] = enemy5;
            wavecounter++;
        }
    }
    bool checkWave()
    {
        int alive = 0;
        for(int i = 0; i < enemies.Length; i++)
        {
            if(enemies[i] == null)
            {
                alive++;
            }
        }
        if(alive == 5)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    void spawnMovment()
    {
        for(int i =0; i <enemies.Length; i++)
        {
            if(enemies[i] != null)
            {
                enemies[i].transform.Translate(new Vector2(0, -5) * Time.deltaTime);
            }
            
        }
        for(int i =0; i < enemies.Length; i++)
        {
            if(enemies[i] != null)
            {
                if(enemies[i].transform.position.y < 3.5f)
                {
                    movmentStop = true;
                    break;
                }
            }
        }
    }
    public int getEnemiesKilled()
    {
        return enemiesKilled;
    }
    public int getWaves()
    {
        return wavecounter;
    }
    public void enemyKilled()
    {
        enemiesKilled++;
    }
}
