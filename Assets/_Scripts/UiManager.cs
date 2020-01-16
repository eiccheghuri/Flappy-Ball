using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{


    public static UiManager instance;
    public void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
    }

    [SerializeField]
    private GameObject game_over_panel;

    public TextMeshProUGUI highScore_text;
    public TextMeshProUGUI score_text;

    public void Update()
    {
       // game_over_panel.SetActive(false);
        score_text.text = ScoreManager.instance.score.ToString();
    }

    public void RestartButtonClicked()
    {
        SceneManager.LoadScene("Game");
    }

    public void MenuButtonClicked()
    {
        SceneManager.LoadScene("Menu");
    }

    public void GameOVer()
    {
        game_over_panel.SetActive(true);
        highScore_text.text = PlayerPrefs.GetInt("HighScore").ToString();
    }



}
