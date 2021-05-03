using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilRobotController : MonoBehaviour
{
    [SerializeField] float dirX, moveSpeed = 3f;
    bool moveRight = true;
    [SerializeField] float xMax = 4f;
    [SerializeField] float xMin = 4f;
    [SerializeField] private GameObject electricityTrigger;

    private void Update()
    {
        if (transform.position.x > xMax)
            moveRight = false;
        if (transform.position.x < xMin)
            moveRight = true;

        if (moveRight)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.position += transform.right *moveSpeed* Time.deltaTime;
            
        }
            
        else
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            transform.position += transform.right * moveSpeed* Time.deltaTime;
            
        }


    }
}
