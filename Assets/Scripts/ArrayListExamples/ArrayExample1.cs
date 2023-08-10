using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample1 : MonoBehaviour
{
    public GameObject[] objeler = new GameObject[5];
    public string[] isimler = new string[4];
    [SerializeField] private string[] nameArray = new string[] { "Mete", "Tibet", "Cem", "Muhammed", "Furkan" };

    private void Start()
    {
        // Array + For Example 1
        for (int i = 0; i < nameArray.Length; i++)
        {
            Debug.Log(nameArray[i]);
        }

        // İsim atamasi
        isimler[0] = "test1";
        isimler[1] = "test2";
        isimler[2] = "test3";
        isimler[3] = "test4";

        for (int i = 0; i < isimler.Length; i++)
        {
            Debug.Log(isimler[i]);
        }
    }

    private void Update()
    {
        Debug.Log(nameArray[0]);
    }
}
