using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIImageManager : MonoBehaviour
{
    public static UIImageManager instance;
    public Image NoBox;
    public Image NoTrigger;
    public Image NoDestory;

    public void Awake()
    {
        if(!instance){
            instance = this;
        }
    }
    public void ImageManager(int bugType)
    {
        Debug.Log(2333);
        if (bugType == 0)
        {
            NoBox.enabled = false;
            NoTrigger.enabled = false;
            NoDestory.enabled = false;
        }
        if (bugType == 1)
        {
            NoBox.enabled = true;
            NoTrigger.enabled = false;
            NoDestory.enabled = false;
        }

        if (bugType == 2)
        {
            NoBox.enabled = false;
            NoTrigger.enabled = true;
            NoDestory.enabled = false;
        }
        if (bugType == 3)
        {
            NoBox.enabled = false;
            NoTrigger.enabled = false;
            NoDestory.enabled = true;
        }

    }
}
