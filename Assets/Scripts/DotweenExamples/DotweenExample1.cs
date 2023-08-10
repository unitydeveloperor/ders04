using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class DotweenExample1 : MonoBehaviour
{
    public List<Color> colors;

    private void Start()
    {
        //transform.position = new Vector3(2, 2, 2);
        //transform.DOMove(new Vector3(10, 2, 2), 3);
        transform.DOJump(new Vector3(5, 0, 0), 10, 3, 2).SetEase(Ease.Linear).OnComplete(() =>
        {
            GetComponent<MeshRenderer>().material.DOColor(colors[Random.Range(0, colors.Count)], 2f).SetLoops(-1);
            transform.DOScale(new Vector3(3, 3, 3), 2).SetLoops(-1, LoopType.Yoyo);
        });
        transform.DORotateQuaternion(Quaternion.Euler(0, 90, 0), 2).SetLoops(-1, LoopType.Yoyo);
    }
}
