using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise9 : MonoBehaviour
{
    public bool wantsVegetarianOption;

    private void Start()
    {
        if (!wantsVegetarianOption == true)
        {
            Debug.Log("Non-vegetarian option coming soon");
        }
        else
        {
            Debug.Log("Vegetarian option coming soon");
        }
    }
}
