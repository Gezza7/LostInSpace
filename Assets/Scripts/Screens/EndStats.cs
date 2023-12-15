using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndStats : MonoBehaviour
{

    private TextMeshProUGUI score;
    private TextMeshProUGUI shards;
    private TextMeshProUGUI kills;
    private TextMeshProUGUI waves;
    private GameData gameData;
    // Start is called before the first frame update
    void Start()
    {
        gameData = FindObjectOfType<GameData>();
        score = GameObject.Find("Score (TMP)").GetComponent<TextMeshProUGUI>();
        kills = GameObject.Find("EnemiesKilled (TMP)").GetComponent<TextMeshProUGUI>();
        waves = GameObject.Find("DeathWave (TMP)").GetComponent<TextMeshProUGUI>();
        shards = GameObject.Find("NebulaShardsEarned (TMP)").GetComponent<TextMeshProUGUI>();
        setUpText();
    }

    private void setUpText()
    {
        score.text = ("Score: " + gameData.getScore()).ToString();
        kills.text = ("Kills: " + gameData.getKills()).ToString();
        waves.text = ("Death Wave: " + gameData.getWave()).ToString();
        shards.text = ("Nebula Shards: " + gameData.getShards()).ToString();
    }
}
