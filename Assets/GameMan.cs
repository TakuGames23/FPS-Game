using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMan : MonoBehaviour
{
   public static GameMan instance;
   public int points = 0;
    public Text scoreText;


    private void Awake()
    {
        instance = this;
    }


    private void Start()
    {
        scoreText.text = points.ToString();
    }


    public void UpdateScore(int score)
    {
        points += score;
        scoreText.text = points.ToString();
    }

    
}
