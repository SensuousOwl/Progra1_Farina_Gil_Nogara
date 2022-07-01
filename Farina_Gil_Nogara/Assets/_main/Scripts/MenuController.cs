using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] private Button playButton;
    [SerializeField] private Button exitButton;
    [SerializeField] private string nextLevel;

    private void Awake()
    {
        playButton.onClick.AddListener(OnClickPlay);
        exitButton.onClick.AddListener(OnClickExit);
    }

    private void OnClickPlay()
    {
        SceneManager.LoadScene(nextLevel);
    }

    private void OnClickExit()
    {
        Application.Quit();
    }
}
