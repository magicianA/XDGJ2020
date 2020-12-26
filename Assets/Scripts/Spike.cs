using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : BugableObjects
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
            if(!this.hasBug)
                collider.gameObject.GetComponent<Player>().alive = false;
        }
    }

}
