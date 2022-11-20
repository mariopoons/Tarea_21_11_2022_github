using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise3 : MonoBehaviour
{
    public int num;
    private int five = 5;
    private int result = 0;
    private void Start()
    {
        if (result == num % five)
        {
            Debug.Log($"¡¡ES DIVISIBLE!!"); 
        } 
        else
        {
            Debug.Log($"¡¡NO ES DIVISIBLE!!");
        }

    }
}
