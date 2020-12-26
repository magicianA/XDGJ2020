using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    public int curStawberry = 0;
    public int curLevel {get;private set;}
    public int totalLevel{
        get{
            return levels.Count;
        }
    }
    private GameObject levelInstanse;
    [SerializeField]
    private List<GameObject> levels = new List<GameObject>(); 
    public void loadLevel(int level)
    {
        Destroy(levelInstanse);
        curLevel = level;
        levelInstanse = Instantiate(levels[level]);
    }
    public bool NextLevel()
    {
        if(curLevel != totalLevel - 1){
            loadLevel(++curLevel);
            return true;
        }else return false;
    }
    
    void Awake()
    {
        if(!instance){
            instance = this;
        }
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
public class LevelData : ScriptableObject
{
    public bool hasBugSlot;    
}