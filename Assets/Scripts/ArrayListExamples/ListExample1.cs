using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListExample1 : MonoBehaviour
{
    [SerializeField] private List<int> Numbers = new List<int>();

    private void Start()
    {
        // daha performansli
        Numbers.Add(5);
        Numbers.Add(10);
        Numbers.Add(20);

        Numbers.Insert(0, 30); // daha az performansli
        Numbers.Remove(20);
        Numbers.RemoveAt(0);
        

        for (int i = 0; i < Numbers.Count; i++)
        {
            Debug.Log(Numbers[i]);
        }

        Numbers.Clear();
        if (Numbers.Count < 1)
            Debug.Log("Numbers List Empty!");
    }
}
