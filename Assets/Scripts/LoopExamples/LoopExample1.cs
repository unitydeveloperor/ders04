using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopExample1 : MonoBehaviour
{
    int counter = 0;

    private void Start()
    {
        // For Loop Example 1
        for (int i = 0; i < 100; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log(i);
            }
        }

        // While Loop Example 1
        while (counter < 10)
        {
            counter++;
            Debug.Log(counter);
        }
    }
}
