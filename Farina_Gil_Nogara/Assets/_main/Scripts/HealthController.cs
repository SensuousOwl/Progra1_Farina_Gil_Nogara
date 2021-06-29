using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthController : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;

    public UnityEvent OnHealthChange = new UnityEvent();
    public UnityEvent OnDead = new UnityEvent();

    private int currentHealth;

    private void Awake()
    {
        ResetLife();
    }

    public void ResetLife()
    {
        currentHealth = maxHealth;
        OnHealthChange.Invoke();
    }

    public void GetDamage(int damage)
    {
        if (damage > 0)
        {
            currentHealth -= damage;

            if (currentHealth <= 0)
            {
                currentHealth = 0;
                OnHealthChange.Invoke();
                Kill();
            }
            else
            {
                OnHealthChange.Invoke();
            }
        }
    }

    public float GetHealthPercentage()
    {
        return (float) currentHealth / maxHealth;
    }

    public void GetHeal(int heal)
    {
        currentHealth += heal;

        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        OnHealthChange.Invoke();

    }

    private void Kill()
    {
        //Destroy(this.gameObject);
        OnDead.Invoke();
    }

    
}
