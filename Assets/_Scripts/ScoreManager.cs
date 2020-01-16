using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager instance;
    public void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
    }


   
    public int score;

    private int high_score;


    public void Start()
    {
        score = 0;

    }

    public void ScoreIncrementScore()
    {
        score++;
    }

    public void StopIncrementScore()
    {
        if(PlayerPrefs.HasKey("HighScore"))
        {
            if(score>PlayerPrefs.GetInt("HighScore"))
            {
                PlayerPrefs.SetInt("HighScore",score);
            }
        }
        else
        {
            PlayerPrefs.SetInt("HighScore", score);


        }


    }




}
