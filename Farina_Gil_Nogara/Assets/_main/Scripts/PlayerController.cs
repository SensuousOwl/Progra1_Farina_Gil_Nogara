
using UnityEngine;
using UnityEngine.Events;


public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 10;
    [SerializeField] private float zRotation;
    [SerializeField] private float boostForce = 5;

    public UnityEvent OnDead = new UnityEvent();

    private Animator myAnimator;
    private Rigidbody2D myRigidbody;
    private HealthController myHealthController;

    private void Awake()
    {
        myAnimator = gameObject.GetComponent<Animator>();

        if(myAnimator == null)
        {
            Debug.LogError("Missing Animator Component.");
        }

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
            myAnimator.SetBool("IsWalking", true);
            transform.rotation = Quaternion.Euler(0,0,270);
            transform.position += transform.up * speed * Time.deltaTime;
        }

        else if (Input.GetKey(KeyCode.A))
        {
            myAnimator.SetBool("IsWalking", true);
            transform.rotation = Quaternion.Euler(0,0,90);
            transform.position += transform.up * speed * Time.deltaTime;
        }

        else if (Input.GetKey(KeyCode.W))
        {
            myAnimator.SetBool("IsWalking", true);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.position += transform.up * speed * Time.deltaTime;
        }

        else if (Input.GetKey(KeyCode.S))
        {
            myAnimator.SetBool("IsWalking", true);
            transform.rotation = Quaternion.Euler(0,0,180);
            transform.position += transform.up * speed * Time.deltaTime;
        }

        else
        {
            myAnimator.SetBool("IsWalking", false);
        }
    }
}