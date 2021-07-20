using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilRobotDamage : MonoBehaviour
{
    [SerializeField] private int damage = 10;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Colision"+collision.gameObject.name);
        HealthController healthController = collision.gameObject.GetComponent<HealthController>();

        if (healthController == null)
        {
            healthController = collision.gameObject.GetComponentInParent<HealthController>();
        }

        if (healthController != null)
        {
            healthController.GetDamage(damage);
        }
    }
}
