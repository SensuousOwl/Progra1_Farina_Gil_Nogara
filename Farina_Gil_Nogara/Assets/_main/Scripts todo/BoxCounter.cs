using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoxCounter : MonoBehaviour
{
    [SerializeField] private int boxesToWin = 4;
    [SerializeField] private BoxLVLManager levelManager;


    /*private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            levelManager.AddBox();
        }
    }

    private void Update()
    {
        
    }*/
}
