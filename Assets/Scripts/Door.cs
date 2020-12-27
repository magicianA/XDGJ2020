using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : BugableObjects
{
    public bool isOpen = false;
    public override void Start()
    {
        base.Start();
        animator.SetBool("hasSlot",hasBugSlot);
    }
    public override void Update()
    {
        if(this.bugType == 1 || isOpen){
            this.gameObject.layer = LayerMask.NameToLayer("Default");
        }else{
            this.gameObject.layer = LayerMask.NameToLayer("Objects");
        }
        animator.SetBool("hasBug",hasBug);
        animator.SetBool("isScanning",LevelManager.instance.isScanning);
        animator.SetBool("isOpen",isOpen);
    }
}
