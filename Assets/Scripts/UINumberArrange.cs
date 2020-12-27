using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class UINumberArrange : MonoBehaviour
{
    public Text berryNumber;
    public Text stageNumber;

    public void  StrawberryCount(int number)
    {
        berryNumber.text = number.ToString();

    }

    public void StageCount(int number)
    {
        stageNumber.text = number.ToString();

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
