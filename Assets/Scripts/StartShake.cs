using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
public class StartShake : MonoBehaviour
{

    public void Start()
    {
        transform.DOLocalMoveY(12,1f).SetEase(Ease.InOutCubic).SetLoops(-1,LoopType.Yoyo);
    }
}
