using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class UINumberArrange : MonoBehaviour
{
    public GameObject bNum;

    public GameObject sNum;
    public Sprite[] berrySprites = new Sprite[3];
    public Sprite[] stageSprites = new Sprite[10];
    public void  StrawberryCount(int number)
    {
        bNum.GetComponent<Image>().sprite = berrySprites[number];
    }

    public void StageCount(int number)
    {
        sNum.GetComponent<Image>().sprite = berrySprites[number];
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
