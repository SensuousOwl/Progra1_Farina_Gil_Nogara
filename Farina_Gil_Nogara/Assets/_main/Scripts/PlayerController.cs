
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 10;
    [SerializeField] private float zRotation;

    //private Animator myAnimator;

    /*private void Awake()
    {
        myAnimator = gameObject.GetComponent<Animator>();

        if(myAnimator == null)
        {
            Debug.LogError("Missing Animator Component.");
        }


    }*/

    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            //myAnimator.SetBool("IsWalking", true);
            transform.rotation = Quaternion.Euler(0,0,270);
            transform.position += transform.up * speed * Time.deltaTime;
        }

        else if (Input.GetKey(KeyCode.A))
        {
            //myAnimator.SetBool("IsWalking", true);
            transform.rotation = Quaternion.Euler(0,0,90);
            transform.position += transform.up * speed * Time.deltaTime;
        }

        else if (Input.GetKey(KeyCode.W))
        {
            //myAnimator.SetBool("IsWalking", true);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.position += transform.up * speed * Time.deltaTime;
        }

        else if (Input.GetKey(KeyCode.S))
        {
            //myAnimator.SetBool("IsWalking", true);
            transform.rotation = Quaternion.Euler(0,0,180);
            transform.position += transform.up * speed * Time.deltaTime;
        }

        /*else
        {
            myAnimator.SetBool("IsWalking", false);
        }*/
    }
}