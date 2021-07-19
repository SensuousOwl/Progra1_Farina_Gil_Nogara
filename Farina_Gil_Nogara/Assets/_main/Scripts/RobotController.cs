using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class RobotController : MonoBehaviour
{
    [SerializeField] private float speed = 10;
    [SerializeField] private float zRotation;
    [SerializeField] private float boostForce = 5;

    public UnityEvent OnDead = new UnityEvent();

    
    private Rigidbody2D myRigidbody;
    private HealthController myHealthController;

    private void Awake()
    {
        myRigidbody = gameObject.GetComponent<Rigidbody2D>();

        myHealthController = gameObject.GetComponent<HealthController>();
        myHealthController.OnDead.AddListener(OnDeadHandler);
    }

    private void OnDeadHandler()
    {
        OnDead.Invoke();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.AddForce(transform.up * boostForce, ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0, 0, 270);
            transform.position += transform.up * speed * Time.deltaTime;
        }

        else if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);
            transform.position += transform.up * speed * Time.deltaTime;
        }

        else if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.position += transform.up * speed * Time.deltaTime;
        }

        else if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Euler(0, 0, 180);
            transform.position += transform.up * speed * Time.deltaTime;
        }
    }
}
