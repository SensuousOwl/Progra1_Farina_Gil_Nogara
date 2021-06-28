using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour
{
    [SerializeField] private HealthController healthController;
    [SerializeField] private Image healthBar;

    private void Awake()
    {
        healthController.OnHealthChange.AddListener(OnHealthChangeHandler);
    }

    private void OnHealthChangeHandler()
    {
        healthBar.fillAmount = healthController.GetHealthPercentage();
    }
}
