using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Serialization;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int score;

    public TextMeshProUGUI scoreText;
    private void Awake()
    {
        instance= this;
    }
    public void AddScore(int ptj)
    {
        score += ptj;
        if(score <= 0)
        {
            score= 0;
        }
    }
    private void Update()
    {
        scoreText.text = score.ToString();
    }
}
