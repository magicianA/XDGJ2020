using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stawberry : BugableObjects
{

    public override void Start()
    {
        base.Start();
        animator.SetBool("hasSlot",hasBugSlot);
    }
    public override void Update()
    {
        animator.SetBool("hasBug",hasBug);
        animator.SetBool("isScanning",LevelManager.instance.isScanning);
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "Player"){
            if(bugType != 1 && bugType != 2 && collider.GetComponent<Player>().bugType != 2){
                LevelManager.instance.curStawberry++;
                if(bugType != 3)
                    Destroy(this.gameObject);
            }
            
        }
    }

}
