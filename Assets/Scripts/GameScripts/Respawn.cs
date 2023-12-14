using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Respawn : MonoBehaviour
{
    [SerializeField] private GameObject playerObject = null;
    [SerializeField] private float respawnDelay = 5.0f;
    private float counter = 0.0f;
    [SerializeField] private float invicibleTimer = 3.0f;
    private GameObject player;
    private TextMeshProUGUI lives;
    private int livesRemaining = 4;
    private GameData gameData;
    // Start is called before the first frame update
    void Start()
    {
        lives = GameObject.Find("LivesText").GetComponent<TextMeshProUGUI>();
        respawn();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        counter -= Time.deltaTime;
        if (player == null)
        {
            if(livesRemaining > 0)
            {
                respawn();
            }
            else
            {
                gameData = FindObjectOfType<GameData>();
                gameData.score = GameObject.Find("GameLoop").GetComponent<Score>().getScore();
                gameData.enemiesKilled = GameObject.Find("WaveSpawner").GetComponent<WaveSpawner>().getEnemiesKilled();
                gameData.waveNumber = GameObject.Find("WaveSpawner").GetComponent<WaveSpawner>().getWaves();
                Application.LoadLevel("GameOver");
            }
        }
        else
        {
            counter = respawnDelay;
            invicibleTimer -= Time.deltaTime;
            if (invicibleTimer <= 0.0f)
            {
                player.GetComponent<Invincible>().setInvincible(false);
            }
        }
    }

    void respawn()
    {
        if (counter <= 0.0f)
        {
            invicibleTimer = 3.0f;
            Vector3 v3 = new Vector3(0, -03.5f, 0);
            player = Instantiate(playerObject, v3, Quaternion.identity);
            player.GetComponent<Invincible>().setInvincible(true);
            livesRemaining--;
            lives.text = ("Lives : " + livesRemaining);
            
        }
    }
   
}
