using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise1 : MonoBehaviour
{
    public float number;

    private void Start()
    {
        if (number < 0)
            Debug.Log($" The number {number} is negative.");

        else if (number == 0)
            Debug.Log($" The number {number} is zero.");

        else
        Debug.Log($" The number {number} is positive.");

    }
}
