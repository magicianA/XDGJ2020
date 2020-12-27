using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class StartShake1 : MonoBehaviour
{
    void Start()
    {
        transform.DOLocalMoveY(0.58f,10f).SetEase(Ease.InOutCubic).SetLoops(2,LoopType.Yoyo);
    }

}
