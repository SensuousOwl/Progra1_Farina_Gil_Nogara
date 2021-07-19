using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Esto utiliza las funciones del administrador de escenas de Unity.


public class ArenaLVLManager : MonoBehaviour
{
    [SerializeField] private RobotController playerRobotController;
    [SerializeField] float levelResetDelay = .25f;
    [SerializeField] float levelLoadDelay = 2f;
    [SerializeField] private string nextWorld;

    GameManager gameManager;
    
    public void Victory()
    {
        FinishStateSequence();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        FinishStateSequence();
    }

    private void FinishStateSequence()
    {
        Invoke("LoadNextScene", levelLoadDelay); //Esta funcion invoca a la funcion que carga al proximo nivel y le proporciona un delay asignado desde el editor.
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(nextWorld);
    }


    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
        playerRobotController.OnDead.AddListener(OnPlayerDeadHandler);
    }
    private void OnPlayerDeadHandler()
    {
        LvlResetSequence();
    }

    private void LvlResetSequence()
    {
        Invoke("ResetScene", levelResetDelay); //Esta funcion invoca a la funcion que carga al proximo nivel y le proporciona un delay asignado desde el editor.
    }

    void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
