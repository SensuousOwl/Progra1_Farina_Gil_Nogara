using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField, Range(0, 1)] private float parallaxEffectMultiplier;

    private Transform cameraTransform;
    private Vector3 lastCameraPosition;
    private SpriteRenderer spriteRenderer;
    private float width;

    void Start()
    {
        cameraTransform = Camera.main.transform;
        lastCameraPosition = cameraTransform.position;
        spriteRenderer = GetComponent<SpriteRenderer>();
        width = spriteRenderer.sprite.bounds.size.x;
    }

    
    void Update()
    {
        Vector3 deltaMovement = cameraTransform.position - lastCameraPosition;
        transform.position += new Vector3(deltaMovement.x * parallaxEffectMultiplier, 0f, 0f);
        lastCameraPosition = cameraTransform.position;

        float distanceWithCamera = cameraTransform.position.x - transform.position.x;

        if (Mathf.Abs(distanceWithCamera) >= width)
        {
            float xMovement = 0;

            if (distanceWithCamera > 0)
            {
                xMovement = width * 2f;
            }
            else if (distanceWithCamera < 0)
            {
                xMovement = width * -2f;
            }

            transform.position += new Vector3(xMovement, 0f, 0f);
        }
    }
}
