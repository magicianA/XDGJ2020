using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIImageManager : MonoBehaviour
{
    public Image NoBox;
    public Image NoTrigger;
    public Image NoDestory;

    public void ImageManager(int bugType)
    {
        if (bugType == 1)
        {
            NoBox.enabled = true;
            NoTrigger.enabled = false ;
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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
