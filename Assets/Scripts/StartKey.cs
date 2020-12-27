using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartKey : MonoBehaviour
{

    public void getKeyDownCode()
    {
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene("GameScene");
            
        }
        
    }

    void Update()
    {
        getKeyDownCode();
    }
}
