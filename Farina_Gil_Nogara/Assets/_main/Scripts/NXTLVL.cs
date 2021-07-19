using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Esto utiliza las funciones del administrador de escenas de Unity.

public class NXTLVL : MonoBehaviour
{
    [SerializeField] private ArenaLVLManager levelManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            levelManager.Victory();
        }
    }
}
