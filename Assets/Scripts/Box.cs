using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : BugableObjects
{    
    public override void Update()
    {
        if(this.bugType == 1){
            this.gameObject.layer = LayerMask.NameToLayer("Default");
        }else{
            this.gameObject.layer = LayerMask.NameToLayer("Objects");
        }
        animator.SetBool("isScanning",LevelManager.instance.isScanning);
        animator.SetBool("hasBug",hasBug);
    }
    public override void Start()
    {
        base.Start();
        animator.SetBool("hasSlot",hasBugSlot);
    }
}
