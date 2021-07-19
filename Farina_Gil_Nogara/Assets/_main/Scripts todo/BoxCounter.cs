using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoxCounter : MonoBehaviour
{
    [SerializeField] private int boxesToWin = 4;
    [SerializeField] private BoxLVLManager levelManager;

    private static int boxCount;
    
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            levelManager.AddBox();
            Debug.Log("Added 1 box");
        }
    }

    
    void Update()
    {
        boxCount = BoxLVLManager.currentBoxes;

        if (boxCount == boxesToWin)
        {
            levelManager.Victory();
        }
    }
    
    
}
