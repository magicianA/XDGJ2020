using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalPlat : BugableObjects
{
    private Player pc;
    void Start()
    {
        pc = GameObject.Find("PC").GetComponent<Player>();
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "Player"){
            if(!this.hasBug && !collider.GetComponent<Player>().hasBug){
                Debug.Log("Success");
                //LevelManager.instance.NextLevel();
            }
        }
    }
}

