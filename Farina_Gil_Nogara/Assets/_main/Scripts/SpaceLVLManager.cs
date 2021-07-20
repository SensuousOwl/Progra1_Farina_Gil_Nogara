using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; //Esto utiliza las funciones del administrador de escenas de Unity.
using UnityEngine;

public class SpaceLVLManager : MonoBehaviour
{
    [SerializeField] private SpaceshipController playerSpaceshipController;
    [SerializeField] float levelResetDelay = .25f;
    [SerializeField] float levelLoadDelay = 2f;
    [SerializeField] private string nextWorld;
    [SerializeField] private string gameOverScene;

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
        playerSpaceshipController.OnDead.AddListener(OnPlayerDeadHandler);
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
        SceneManager.LoadScene(gameOverScene);
    }
}
