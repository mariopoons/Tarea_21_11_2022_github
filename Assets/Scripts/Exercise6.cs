using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise6 : MonoBehaviour
{
    public float distanceTraveler;
    public float totalDistance=20;

    private void Start()
    {
        if (distanceTraveler >= totalDistance)
        {
            Debug.Log($"Congratulations! You have completed the total distance with {distanceTraveler} meters.");
        }
        else
        {
            Debug.Log($"Oh… You still have {totalDistance-distanceTraveler} meters left to complete the total distance.");
        }
    }
}
