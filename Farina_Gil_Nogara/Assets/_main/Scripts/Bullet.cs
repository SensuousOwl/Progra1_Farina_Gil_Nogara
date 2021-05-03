using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 10;
    [SerializeField] private float deadTime = 0.5f;
    [SerializeField] private int damage = 10;

    private float currentDeadTime;

    private void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;

        currentDeadTime += Time.deltaTime;

        if (currentDeadTime >= deadTime)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        HealthController healthController = collision.gameObject.GetComponent<HealthController>();

        if (healthController == null)
        {
            healthController = collision.gameObject.GetComponentInParent<HealthController>();
        }

        if (healthController != null)
        {
            healthController.GetDamage(damage);
        }

        Destroy(gameObject);
        Destroy(this.gameObject);
    }
}
