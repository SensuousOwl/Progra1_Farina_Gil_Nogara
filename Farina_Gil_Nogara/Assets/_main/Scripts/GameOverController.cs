using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameOverController : MonoBehaviour
{
    [SerializeField] private string retryLevel;
    [SerializeField] private Button retryButton;

    private void Awake()
    {
        retryButton.onClick.AddListener(OnClickRetry);
    }

    private void OnClickRetry()
    {
        SceneManager.LoadScene(retryLevel);
    }
}
