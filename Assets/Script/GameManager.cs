using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int puntaje;

    public TextMeshProUGUI scoreText;
    private void Awake()
    {
        instance= this;
    }
    public void AddPuntaje(int ptj)
    {
        puntaje += ptj;
        if(puntaje <= 0)
        {
            puntaje= 0;
        }
    }
    private void Update()
    {
        scoreText.text = puntaje.ToString();
    }
}
