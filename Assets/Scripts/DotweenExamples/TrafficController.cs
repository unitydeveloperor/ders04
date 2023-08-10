using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TrafficController : MonoBehaviour
{
    public List<GameObject> cars;

    private void Start()
    {
        Sequence traffic = DOTween.Sequence();

        traffic.Append(cars[0].transform.DOMoveZ(10, 2));
        traffic.Append(cars[1].transform.DOMoveX(0, 2));
        traffic.Join(cars[1].transform.DOMoveZ(-3, 2).SetDelay(0.5f));
        traffic.Append(cars[2].transform.DOMoveX(4, 2));
    }
}
