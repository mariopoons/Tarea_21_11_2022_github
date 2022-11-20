using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise7 : MonoBehaviour
{
    public string sumSubstractProductDivison;
    public float x;
    public float y;

    private void Start()
    {
        if (sumSubstractProductDivison == "sum" || sumSubstractProductDivison == "Sum")
        {
            Debug.Log($"{x}+{y}={x + y}");
        }
        else if (sumSubstractProductDivison == "substract" || sumSubstractProductDivison == "Substract")
        {
            Debug.Log($"{x}-{y}={x - y}");
        }
        else if (sumSubstractProductDivison == "product" || sumSubstractProductDivison == "product")
        {
            Debug.Log($"{x}*{y}={x * y}");
        }
        else if (sumSubstractProductDivison == "division" || sumSubstractProductDivison == "Division")
        {
            Debug.Log($"{x}/{y}={x / y}");
        }
    }

}
