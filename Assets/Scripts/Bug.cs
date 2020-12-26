using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugableObjects : MonoBehaviour
{
    public bool hasBug {get{
        return bugType != 0;
    }}
    public bool hasBugSlot;
    public int bugType;
    [SerializeField]
    private List<int> extraBugs = new List<int>();
    public void moreBugs()
    {
        if(extraBugs.Count > 0){
            bugType = extraBugs[0];
            extraBugs.RemoveAt(0);
        }
    }
    public virtual void Start()
    {
        ;
    }
    public virtual void Update()
    {
        ;
    }
}
