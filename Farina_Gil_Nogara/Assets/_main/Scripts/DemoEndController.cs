using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DemoEndController : MonoBehaviour
{
    [SerializeField] private Button mainMenuButton;

    private void Awake()
    {
        mainMenuButton.onClick.AddListener(OnClickMainMenu);
    }

    private void OnClickMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
