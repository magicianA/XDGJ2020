using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : BugableObjects
{
    public bool isPressed = false;
    public Door door;
    public override void Start()
    {
        base.Start();
        animator.SetBool("hasSlot",hasBugSlot);
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "Player"){
            if(collider.GetComponent<Player>().bugType != 2 && this.bugType != 1 && this.bugType != 2){
                isPressed = !isPressed;
                if(door.bugType == 3)
                    Instantiate(door.gameObject);
                door.isOpen = isPressed;
                //Instantiate(door.gameObject);
            }
        }
    }
    public override void Update()
    {
        animator.SetBool("hasBug",hasBug);
        animator.SetBool("isScanning",LevelManager.instance.isScanning);
        animator.SetBool("isPressed",isPressed);
    }
}
