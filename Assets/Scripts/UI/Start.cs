using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Start : MonoBehaviour
{


    public void newGame()
    {
        LevelManager.playedLevel = 0;
        SceneManager.LoadScene("GameScene");
    }
    public void continueGame()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void exitGame()
    {
        Application.Quit();
    }


}
