using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class HealthController : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;
    [SerializeField] private float levelResetDelay = .25f;

    public UnityEvent OnHealthChange = new UnityEvent();

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
                LevelRestart();
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
        Destroy(this.gameObject);
    }

    private void LevelRestart()
    {
        Invoke("ResetScene", levelResetDelay);
    }

    void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
