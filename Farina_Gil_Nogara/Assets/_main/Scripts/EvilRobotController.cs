using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilRobotController : MonoBehaviour
{
    float dirX, moveSpeed = 3f;
    bool moveRight = true;

    private void Update()
    {
        if (transform.position.x > 4f)
            moveRight = false;
        if (transform.position.x < -4f)
            moveRight = true;

        if (moveRight)
        {
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
            
        else
        {
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
            transform.rotation = Quaternion.Euler(0, 0, 180);
        }


    }
}
