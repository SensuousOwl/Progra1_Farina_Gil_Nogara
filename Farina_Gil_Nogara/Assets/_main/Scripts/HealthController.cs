using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;

    private int currentHealth;

    private void Awake()
    {
        ResetLife();
    }

    public void ResetLife()
    {
        currentHealth = maxHealth;
    }

    public void GetDamage(int damage)
    {
        if (damage > 0)
        {
            currentHealth -= damage;

            if (currentHealth <= 0)
            {
                currentHealth = 0;
                Kill();
            }
        }
    }

    public void GetHeal(int heal)
    {
        currentHealth += heal;

        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }

    private void Kill()
    {
        Destroy(this.gameObject);
    }
}
