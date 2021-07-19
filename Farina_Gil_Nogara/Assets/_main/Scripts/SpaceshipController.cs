using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class SpaceshipController : MonoBehaviour
{
    [SerializeField] private float speed = 10;
    [SerializeField] private GameObject laserPrefab;
    [SerializeField] private Transform shootPoint;
    [SerializeField] private float shootCooldown = 0.5f;

    public UnityEvent OnDead = new UnityEvent();

    private float currentCooldown;

    private Rigidbody2D myRigidbody;
    private HealthController myHealthController;

    private void Awake()
    {
        myRigidbody = gameObject.GetComponent<Rigidbody2D>();
        myHealthController = gameObject.GetComponent<HealthController>();
        //myHealthController.OnDead.AddListener(OnDeadHandler);
    }

    private void OnDeadHandler()
    {
        OnDead.Invoke();
    }

    // Start is called before the first frame update
    void Start()
    {
        ResetCooldown();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.up * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.up * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }

        /*if (List = true)
        {
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += transform.right * speed * Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.position -= transform.right * speed * Time.deltaTime;
            }

            
        }*/
    }

    private void ResetCooldown()
    {
        currentCooldown = shootCooldown;
    }

    private void Shoot()
    {
        GameObject laser = Instantiate(laserPrefab);
        laser.transform.position = shootPoint.position;
        //laser.transform.rotation = transform.rotation;
    }
}
