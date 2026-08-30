using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public thornMove thornMV;
    public float gameSpeed = 3;
    public GameObject StartScreen;

    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        score = 0;
        scoreText.text = score.ToString();
        thornMV.speed = 4;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore()
    {
        score++;
        scoreText.text = score.ToString();
        if(thornMV.speed < 25)
        {
            thornMV.speed += gameSpeed;
        }
    }

    public void StartGame()
    {
        Time.timeScale = 1;
        StartScreen.SetActive(false);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
        thornMV.speed = 4;
    }
}
