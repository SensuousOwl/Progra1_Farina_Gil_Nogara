using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int currentNovas;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public int GetNovas()
    {
        return currentNovas;
    }

    public void AddNovas(int novasToAdd)
    {
        currentNovas += novasToAdd;
    }
}
