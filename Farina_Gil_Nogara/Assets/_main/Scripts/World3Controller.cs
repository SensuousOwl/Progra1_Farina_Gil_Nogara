using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class World3Controller : MonoBehaviour
{
    [SerializeField] private Button robotArenaButton;
    [SerializeField] private Button acceptButton;


    private void Awake()
    {
        robotArenaButton.onClick.AddListener(OnClickRobotArena);
        acceptButton.onClick.AddListener(OnClickAccept);
    }

    private void OnClickRobotArena()
    {
        SceneManager.LoadScene("Robot Arena LVL 3");
    }
    private void OnClickAccept()
    {
        SceneManager.LoadScene("Box LVL 3");
    }
}