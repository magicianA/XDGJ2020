using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : BugableObjects
{
    public override void Start()
    {
        base.Start();
        for(int i = 0;i < transform.childCount;i++){
            Animator canimator = transform.GetChild(i).GetComponent<Animator>();
            if(canimator != null){
                canimator.SetBool("hasSlot",hasBugSlot);
            }
        }
    }
    public override void Update()
    {
        for(int i = 0;i < transform.childCount;i++){
            Animator canimator = transform.GetChild(i).GetComponent<Animator>();
            if(canimator != null){
                canimator.SetBool("hasBug",hasBug);
                canimator.SetBool("isScanning",LevelManager.instance.isScanning);
            }
        }
    }
}
