using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CarLookAt : MonoBehaviour
{
    public GameObject target;

    private void Update()
    {
        transform.DOLookAt(target.transform.position, 0.5f);
    }
}
