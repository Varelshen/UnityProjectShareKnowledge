using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuFunction : MonoBehaviour
{
    public static bool GameIsPause = false;

    public GameObject PauseMenuUI;

    public GameObject SceneGameplay;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
    }

    void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
    }

    public void LoadMenu()
    {
        PauseMenuUI.SetActive(false);
        GameIsPause = false;
        Time.timeScale = 1f;
        ScoreScriptBrac.ScoreRecolected = 0;
        Destroy(SceneGameplay);
        SceneManager.LoadScene("MainMenu");
    }

    public void TryAgain()
    {
        ScoreScriptBrac.ScoreRecolected = 0;
        PauseMenuUI.SetActive(false);
        GameIsPause = false;
        Time.timeScale = 1f;
        Destroy(SceneGameplay);
        SceneManager.LoadScene("GameStart");

    }
}
