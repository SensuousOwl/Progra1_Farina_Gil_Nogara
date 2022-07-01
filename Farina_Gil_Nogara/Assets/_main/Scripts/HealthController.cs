using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthController : MonoBehaviour
{
    [SerializeField] private float maxHealth = 100;

    public UnityEvent OnHealthChange = new UnityEvent();
    public UnityEvent OnDead = new UnityEvent();

    private float currentHealth;
    private bool canTakeDamage = true;

    private void Awake()
    {
        ResetLife();
    }

    public void ResetLife()
    {
        currentHealth = maxHealth;
        OnHealthChange.Invoke();
    }

    public void GetDamage(float damage)
    {
        if (damage > 0 && canTakeDamage)
        {
            StartCoroutine(WaitForSeconds());
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
    private IEnumerator WaitForSeconds()
    {
        canTakeDamage = false;
        yield return new WaitForSeconds (1);
        canTakeDamage = true;
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
        //Destroy(gameObject);
        OnDead.Invoke();
    }

    
}
