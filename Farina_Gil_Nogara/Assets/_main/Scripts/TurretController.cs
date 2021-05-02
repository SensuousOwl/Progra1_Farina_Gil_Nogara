using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform shootPoint;
    [SerializeField] private float shootCooldown = 0.5f;

    private float currentCooldown;

    private void Start()
    {
        ResetCooldown();
    }

    private void Update()
    {
        currentCooldown -= Time.deltaTime;

        if (currentCooldown <= 0)
        {
            ResetCooldown();
            Shoot();
        }
    }

    private void ResetCooldown()
    {
        currentCooldown = shootCooldown;
    }

    private void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab);
        bullet.transform.position = shootPoint.position;
        bullet.transform.rotation = transform.rotation;
    }
}
