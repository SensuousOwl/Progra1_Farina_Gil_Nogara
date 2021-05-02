using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent] // Atrubutes, does not allow more than 1 script
public class Oscillator : MonoBehaviour
{
    [SerializeField] Vector3 movementVector = new Vector3(10f,10f,10f);// proves that the script is on an object

    [SerializeField] float period = 3f;

    [SerializeField] float modifier = 0f;

    // todo remove from inpector later
    [Range(0,1)] [SerializeField] float movementFactor; // 0 for not moved, 1 for fully moved

    Vector3 startingPos;

    // Start is called before the first frame update
    void Start()
    {
        startingPos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (period <= Mathf.Epsilon) { return; } //protect against period=0
        float cycles = Time.time / period;// grows continually from 0

        const float tau = Mathf.PI * 2; // about 6.28
        float rawSinWave = Mathf.Sin(cycles * tau+modifier);

        movementFactor = rawSinWave / 2f + 0.5f;// now it goes from 0 to 1 and back to 0

        Vector3 offset = movementFactor * movementVector;
        transform.position = startingPos + offset;
    }
}
