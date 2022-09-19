using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    /// <summary>
    /// Function that loads a new scene and resets the timeScale
    /// </summary>
    /// <param name="newScene">New scene to be loaded</param>
    public void ChangeToScene(string newScene)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(newScene);
    }

    /// <summary>
    /// Function that reloads the current scene and resets the timeScale
    /// </summary>
    public void ReloadScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
