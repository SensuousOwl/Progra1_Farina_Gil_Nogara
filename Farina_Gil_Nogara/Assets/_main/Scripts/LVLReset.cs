using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LVLReset : MonoBehaviour
{
    [SerializeField] float levelResetDelay = .25f;
    [SerializeField] PlayerController playerController;


    
    private void Awake()
    {
        playerController.OnDead.AddListener(OnPlayerDeadHandler);
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
