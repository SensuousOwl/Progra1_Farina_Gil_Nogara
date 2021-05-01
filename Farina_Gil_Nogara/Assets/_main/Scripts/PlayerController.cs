
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
            transform.rotation = Quaternion.Euler(0,0,270);
            transform.position += transform.up * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(0,0,90);
            transform.position += transform.up * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.position += transform.up * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Euler(0,0,180);
            transform.position += transform.up * speed * Time.deltaTime;
        }
    }
}