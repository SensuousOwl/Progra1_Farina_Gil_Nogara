using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField] private GameObject door;

    //Esto es lo que pasa cuando el player interactua con las llaves del nivel.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
        Destroy(door.gameObject);
    }
}
