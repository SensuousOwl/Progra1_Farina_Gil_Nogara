using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Esto utiliza las funciones del administrador de escenas de Unity.

public class NXTLVL : MonoBehaviour
{
    [SerializeField] float levelLoadDelay = 2f;

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
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex; //busca en que escena estamos.
        int nextSceneIndex = currentSceneIndex + 1; //prepara al SceneManager para pasar a la escena que sigue.
        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings) //este if verifica que si nos encontramos en la ultima escena, que el juego vuelva al primer nivel.
        {
            nextSceneIndex = 0;
        }
        SceneManager.LoadScene(nextSceneIndex);
    }
}
