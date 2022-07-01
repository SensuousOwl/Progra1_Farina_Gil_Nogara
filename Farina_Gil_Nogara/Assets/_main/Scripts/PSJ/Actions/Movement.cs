using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 10;
    [SerializeField] private float zRotation;
    [SerializeField] private float boostForce = 5;
    private Rigidbody2D myRigidbody;

    private void Awake()
    {
        myRigidbody = gameObject.GetComponent<Rigidbody2D>();
    }
}
