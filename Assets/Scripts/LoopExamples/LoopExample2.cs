using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopExample2 : MonoBehaviour
{
    int counter = 0;
    private void Start()
    {
        // For Example 2
        for (int i = 0; i < 50; i += 2)
        {
            Debug.Log(i);
        }

        // While Example 2
        while (counter < 50)
        {
            counter = counter + 2;
            Debug.Log(counter);
        }
    }
}
