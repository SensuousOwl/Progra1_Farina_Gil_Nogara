using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform shootPoint;
    [SerializeField] private float shootCooldown = 0.5f;
    [SerializeField] private float rotationTimer = 1f;


    private float currentRotationTimer;
    private float currentCooldown;
    //private int nextAngle = 90;

    private void Start()
    {
        ResetCooldown();
    }

    private void Update()
    {
        currentRotationTimer += Time.deltaTime;

        if (currentRotationTimer > rotationTimer)
        {
            //transform.eulerAngles = new Vector3(0, 0, Time.realtimeSinceStartup * 90);
            //nextAngle += 90;
            transform.Rotate(new Vector3(0, 0, 90));
            currentRotationTimer = 0;
            Shoot();
        }
        
        
        
        /*currentCooldown -= Time.deltaTime;

        if (currentCooldown <= 0)
        {
            ResetCooldown();
            Shoot();
        }*/

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
