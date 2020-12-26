using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stawberry : BugableObjects
{

    public override void Start()
    {
        
    }
    public override void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "Player"){
            if(!hasBug && !collider.GetComponent<Player>().hasBug){
                LevelManager.instance.curStawberry++;
                Destroy(this.gameObject);
            }
            
        }
    }

}
