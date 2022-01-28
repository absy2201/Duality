using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Menu : MonoBehaviour
{
    public Button playButton;
    public Button quitButton;

    private void Start()
    {
        playButton.onClick.AddListener(() => Play());
        quitButton.onClick.AddListener(() => Quit());
    }

    private void Play()
    {
        int buildIndex = SceneManager.GetActiveScene().buildIndex;
        if (SceneManager.GetSceneByBuildIndex(buildIndex + 1) != null)
        {
            SceneManager.LoadScene(buildIndex + 1);
        }
    }

    private void Quit()
    {
        Application.Quit();
    }
}
