using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private List<int> doorKeyList = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (doorKeyList.Count == 2)
        {
            Destroy(this.gameObject);
        }
    }

    void AddToList()
    {
        doorKeyList.Add(1);
    }
}
