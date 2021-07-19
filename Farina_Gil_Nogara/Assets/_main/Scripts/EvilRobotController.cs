using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilRobotController : MonoBehaviour
{
    [SerializeField] float dirX, moveSpeed = 3f;
    //bool moveRight = true;
    //[SerializeField] float xMax = 4f;
    //[SerializeField] float xMin = 4f;
    [SerializeField] private GameObject electricityTrigger;
    [SerializeField] private float wallDetectionDist = 1;
    [SerializeField] private Transform wallDetectionPoint;
    [SerializeField] private LayerMask wallDetectionLayer;

    private Rigidbody2D myRigidbody;

    /*private void Update()
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


    }*/
    private void Awake()
    {
        myRigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(wallDetectionPoint.position, Vector2.right, wallDetectionDist, wallDetectionLayer);
        if (hit)
        {
            transform.Rotate(0, 180, 0);
        }
    }

    private void FixedUpdate()
    {
        myRigidbody.velocity = transform.right * moveSpeed;
    }
}
