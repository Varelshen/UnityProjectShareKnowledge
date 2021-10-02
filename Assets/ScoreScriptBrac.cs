using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScriptBrac : MonoBehaviour
{

    public GameObject videosceneMainGameplay;

    public static int ScoreRecolected = 0;
    Text Score;
    // Update is called once per frame
    private void Start()
    {
        Score = GetComponent<Text>();
    }

    void Update()
    {

        Score.text = "" + ScoreRecolected;

        if (ScoreRecolected == 14)
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            ScoreRecolected = 0;
            Destroy(videosceneMainGameplay);
        }
    }
}
