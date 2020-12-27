﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    public int curStawberry = 0;
    public bool isScanning = false;
    public int curLevel {get;private set;}
    public static int playedLevel = 0;
    public int totalLevel{
        get{
            return levels.Count;
        }
    }
    private GameObject levelInstanse;
    [SerializeField]
    private List<GameObject> levels = new List<GameObject>(); 
    [SerializeField]
    private GameObject pc;
    public void loadLevel(int level)
    {
        Destroy(levelInstanse);
        pc.GetComponent<Player>().alive = false;
        curLevel = level;
        curStawberry = 0;
        levelInstanse = Instantiate(levels[level]);
    }
    public bool NextLevel()
    {
        if(curLevel != totalLevel - 1){
            loadLevel(++curLevel);
            return true;
        }else return false;
    }
    public void BeginLevel()
    {
        loadLevel(playedLevel);
    }
    void Awake()
    {
        if(!instance){
            instance = this;
        }
    }
    void Start()
    {
        pc = GameObject.Find("PC");
        BeginLevel();
    }
    void Update()
    {
        
    }
}