using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class CinematicaLoseScript : MonoBehaviour
{
    public GameObject videoscene;
    public VideoPlayer vidio;

    // Start is called before the first frame update
    private void Awake()
    {
        vidio = GetComponent<VideoPlayer>();
        vidio.Play();
        vidio.loopPointReached += CheckOver;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            DOthis();
        }
    }

    public void DOthis()
    {
        SceneManager.LoadScene("LoseMenuFinal");
        Destroy(videoscene);
    }

    void CheckOver(VideoPlayer vp)
    {
        SceneManager.LoadScene("LoseMenuFinal");
        Destroy(videoscene);
        gameObject.SetActive(false);
    }
}
