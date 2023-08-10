using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ObjectRotator : MonoBehaviour
{
    private void Start()
    {
        transform.DORotateQuaternion(Quaternion.Euler(-90, 0, 0), 0.5f).SetEase(Ease.Linear).SetLoops(-1, LoopType.Incremental);
    }
}
