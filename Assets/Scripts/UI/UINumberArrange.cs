using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class UINumberArrange : MonoBehaviour
{
    public static UINumberArrange instance;
    public GameObject bNum;

    public GameObject sNum;
    public Sprite[] berrySprites = new Sprite[3];
    public Sprite[] stageSprites = new Sprite[10];
    void Awake()
    {
        if(!instance){
            instance = this;
        }
    }
    public void  StrawberryCount(int number)
    {
        bNum.GetComponent<Image>().sprite = berrySprites[number];
    }

    public void StageCount(int number)
    {
        sNum.GetComponent<Image>().sprite = stageSprites[number];
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
