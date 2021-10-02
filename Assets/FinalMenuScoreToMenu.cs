using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalMenuScoreToMenu : MonoBehaviour
{
    public GameObject CurrentScene;

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Destroy(CurrentScene);
    }
}
