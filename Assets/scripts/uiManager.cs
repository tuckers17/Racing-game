using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class uiManager : MonoBehaviour
{
    public Text scoreText;
    bool gameOver;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        score = 0;
        InvokeRepeating("scoreUpdate", 1.0f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "score: " + score;

    }

    void scoreUpdate ()
    {
        if (gameOver == false)
        {
            score += 1;
        }
    }

    public void gameOverActivated()
    {
        gameOver = true;
    }
    public void play()
    {
        SceneManager.LoadScene("Level1");
          
    }


    public void Pause()
    {

        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }
}
