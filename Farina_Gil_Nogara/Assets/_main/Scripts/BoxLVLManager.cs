using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxLVLManager : MonoBehaviour
{
    private int currentBoxes = 0;

    public void AddBox()
    {
        currentBoxes++;
    }
    
    public void Victory()
    {
        
    }

    public void LevelReset()
    {
        // TODO: resetear el nivel
    }
}
