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
        SceneManager.LoadScene("World 1");
    }
}
