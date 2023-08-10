using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DayNightLoop : MonoBehaviour
{
    private void Start()
    {
        transform.DORotateQuaternion(Quaternion.Euler(90, transform.localRotation.y, 0), 10).SetLoops(-1, LoopType.Yoyo);
    }
}
