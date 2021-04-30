
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private string playerName = "Default";
    [SerializeField] private float speed = 10;
    [SerializeField] private float zRotation;

    private void Awake()
    {

    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.up * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.up * speed * Time.deltaTime;
        }
    }
}