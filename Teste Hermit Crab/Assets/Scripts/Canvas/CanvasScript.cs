using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasScript : MonoBehaviour
{
    //Public Variables
    public TMP_Text scoreTXT;
    public TMP_Text tapToPlayTXT;
    public TMP_Text endGameScoreTXT;
    public GameObject gameOverScreen;
    public bool gameStarted;

    #region Singleton
    public static CanvasScript instance;

    private void Awake()
    {
        instance = this;
    }

    #endregion

    private void Start()
    {
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        scoreTXT.text = "SCORE: " + PlayerController.instance.score.ToString();
        endGameScoreTXT.text = "SCORE: " + PlayerController.instance.score.ToString();


        if ((Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0) && !gameStarted)
        {
            StartGame();
        }
    }

    /// <summary>
    /// Function that starts the game, by reseting the timeScale
    /// </summary>
    public void StartGame()
    {
        gameStarted = true;
        tapToPlayTXT.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }

    /// <summary>
    /// Function that stops the game, by stopping the timeScale
    /// </summary>
    public void EndGame()
    {
        Time.timeScale = 0f;
        scoreTXT.gameObject.SetActive(false);
        gameOverScreen.SetActive(true);
    }
}
