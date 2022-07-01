using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{
    private Rigidbody2D myRigidbody;
    [SerializeField] private float _boost;

    private void Awake()
    {
        myRigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    public void Do()
    {
        myRigidbody.AddForce(transform.up * _boost, ForceMode2D.Impulse);
    }
}
