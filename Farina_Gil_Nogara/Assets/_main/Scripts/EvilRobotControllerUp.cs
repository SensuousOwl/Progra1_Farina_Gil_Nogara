using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilRobotControllerUp : MonoBehaviour
{
    [SerializeField] float dirX, moveSpeed = 3f;
    
    [SerializeField] private GameObject electricityTrigger;
    [SerializeField] private float wallDetectionDist = 1;
    [SerializeField] private Transform wallDetectionPoint;
    [SerializeField] private LayerMask wallDetectionLayer;

    private Rigidbody2D myRigidbody;

    private void Awake()
    {
        myRigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    
    private void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(wallDetectionPoint.position, Vector2.up, wallDetectionDist, wallDetectionLayer);
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
