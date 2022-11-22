using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise3 : MonoBehaviour
{
    public int num;
    private void Start()
    {
        if (0 == num % 5)
        {
            Debug.Log($"¡¡ES DIVISIBLE ENTRE CINCO!!"); 
        } 
        else
        {
            Debug.Log($"¡¡NO ES DIVISIBLE ENTRE CINCO!!");
        }

    }
}
