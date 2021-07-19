using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BoxLVLManager : MonoBehaviour
{
    [SerializeField] private string nextLevel;

    public static int currentBoxes = 0;

    public void AddBox()
    {
        currentBoxes++;
    }
    
    public void Victory()
    {
        SceneManager.LoadScene(nextLevel);
    }
    public void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            LevelReset();
        }
    }

    public void LevelReset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
