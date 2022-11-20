using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise4 : MonoBehaviour
{
    public float basex;
    public float highy;

    private void Start()
    {
        if (basex * highy / 2 > 0)
        { 
            Debug.Log($"The are of {basex} is {basex * highy / 2}."); 
        }
        else
        {
            Debug.Log("We can't calculate the area.");
        }

    }

}
