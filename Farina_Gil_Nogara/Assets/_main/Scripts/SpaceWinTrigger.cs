using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceWinTrigger : MonoBehaviour
{
    [SerializeField] private SpaceLVLManager levelManager;

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            levelManager.Victory();
        }
    }*/

    [SerializeField] private float timeRemaining = 10;
    public bool timerIsRunning = false;

    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                levelManager.Victory();
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
    }
}
