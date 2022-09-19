using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasScript : MonoBehaviour
{
    //Public Variables
    public TMP_Text scoreTXT;
    public GameObject gameOverScreen;

    #region Singleton
    public static CanvasScript instance;

    private void Awake()
    {
        instance = this;
    }

    #endregion

    // Update is called once per frame
    void Update()
    {
        scoreTXT.text = PlayerController.instance.score.ToString();
    }


    public void EndGame()
    {
        Time.timeScale = 0f;
        scoreTXT.gameObject.SetActive(false);
        gameOverScreen.SetActive(true);
    }
}
