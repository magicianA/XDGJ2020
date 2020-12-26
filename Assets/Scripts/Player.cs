using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : BugableObjects
{
    [SerializeField]
    private ColorAdjustEffect mainCamera = null;
    [SerializeField]
    private Vector3 revivePoint = new Vector3(-15.22f,5.78f,0);
    public bool alive = true;
    public bool isScanning = false;
    public int bugStore = 0;
    public bool hasStore{get{
        return bugStore == 0;
    }} 
    private PlatformerMotor2D motor2D;
    public override void Start()
    {
        motor2D = this.GetComponent<PlatformerMotor2D>();
    }
    public override void Update()
    {
        if(!alive){
            //LevelManager.instance.Restart();
            transform.position = revivePoint;
            alive = true;
            bugType = 0;
            motor2D.velocity = Vector2.zero;
            
            motor2D.staticEnvLayerMask = LayerMask.GetMask("Platform","Objects");
        }
        if(Input.GetKeyDown(KeyCode.Tab)){
            isScanning = true;
            mainCamera.saturation = 0;
        }
        if(Input.GetKeyUp(KeyCode.Tab)){
            isScanning = false;
            mainCamera.saturation = 1;
        }
        if(isScanning){
            if(Input.GetMouseButtonDown(0)){
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector3.back, 5f, LayerMask.GetMask("Default","PC","Objects"));
                if(hit){
                    if(hit.collider.tag == "BugableObjects" || hit.collider.tag == "Player"){
                        Debug.Log(hit.collider.name);
                        BugableObjects col = hit.collider.GetComponent<BugableObjects>();
                        if(col.hasBug && this.hasStore){
                            if(Vector3.Distance(col.transform.position,this.transform.position) <= 10f){
                                Debug.Log("Bug stored from " + col.name);
                                this.bugStore = col.bugType;
                                col.bugType = 0;
                                col.moreBugs();
                            }else{
                                Debug.Log("Too Far!");
                            }
                        }
                        else if(col.hasBugSlot && !col.hasBug && !this.hasStore){
                            if(Vector3.Distance(col.transform.position,this.transform.position) <= 10f){
                                Debug.Log("Bug Placed to " + col.name);
                                col.bugType = this.bugStore;
                                this.bugStore = 0;
                            }else{
                                Debug.Log("Too Far!");
                            }
                        }
                    }
                }
            }
        }
        if(hasBug){
            switch(bugType){
                case 1:
                    motor2D.staticEnvLayerMask = LayerMask.GetMask("Water");
                    transform.position = transform.position + new Vector3(0,0.01f,0);
                    break;
            }
        }
        if(transform.position.y < -20){
            alive = false;
        }
    }
}
