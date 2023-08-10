using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopSamples : MonoBehaviour
{
    int number = 0;

    private void Start()
    {
        // While Loop
        while (number < 5)
        {
            number++;
            Debug.Log(number);
        }

        //// For Loop
        for (int i = 0; i < number; i++)
        {
            Debug.Log(i);
        }

        // Do-While Loop
        do
        {
            number++;
            Debug.Log(number);

        } while (number < 0);
    }
}
