using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


public class Timer : MonoBehaviour
{

    public AudioSource SourceSuspense;
    public AudioClip ClipSuspense;

    public static float currentTime;
    public int startingTime = 64;

    [SerializeField] Text countdownText;
    void Start()
    {
        currentTime = startingTime;
    }
    void Update()
    {
        currentTime = currentTime -1 * Time.deltaTime;
        countdownText.text = currentTime.ToString(currentTime + "S");
        countdownText.text = (currentTime + " S");

        if(currentTime <= 27)
        {
            SourceSuspense.PlayOneShot(ClipSuspense);
        }

        if (currentTime <= 0)
        {
            currentTime = 0;
            ScoreScriptBrac.ScoreRecolected = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }

    }
}