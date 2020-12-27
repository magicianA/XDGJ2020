using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalPlat : BugableObjects
{
    private Player pc;
    public override void Start()
    {
        base.Start();
        pc = GameObject.Find("PC").GetComponent<Player>();
        animator.SetBool("hasSlot",hasBugSlot);
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "Player"){
            if(this.bugType != 1 && this.bugType != 2 && pc.bugType != 1 && pc.bugType != 2 && LevelManager.instance.curStawberry == 3){
                Debug.Log("Success");
                LevelManager.instance.NextLevel();
            }
        }
    }
    public override void Update()
    {
        animator.SetBool("hasBug",hasBug);
        animator.SetBool("isScanning",LevelManager.instance.isScanning);
        if(LevelManager.instance.curStawberry == 3  ){
            transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = true;
        }else{
            transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}

