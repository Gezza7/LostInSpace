using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{

    private TextMeshProUGUI scoreTxt;
    private int score = 0;
    private GameData gameData;
    // Start is called before the first frame update
    void Start()
    {
        scoreTxt = GameObject.Find("ScoreText").GetComponent<TextMeshProUGUI>();
        updateScore(score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateScore(int newScore)
    {
        score += newScore;
        scoreTxt.text = ("Score : " + score).ToString();
    }
    public int getScore()
    {
        return score;
    }
}
