using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : BugableObjects
{
    public bool isOpen = false;
    public override void Update()
    {
        if(this.bugType == 1 || isOpen){
            this.gameObject.layer = LayerMask.NameToLayer("Default");
        }else{
            this.gameObject.layer = LayerMask.NameToLayer("Objects");
        }
    }
}
