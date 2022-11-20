using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise10 : MonoBehaviour
{
    public int year;
    private int four = 4;
    private int result = 0;

    private void Start()
    {
        if (result == year % four)
        {
            Debug.Log($"Is a leap year");
        }
        else
        {
            Debug.Log($"is not a leap year");
        }
    }
}
