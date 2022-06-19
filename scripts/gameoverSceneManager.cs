using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameoverSceneManager : MonoBehaviour
{

    public void homeButtonDown(){
        SceneManager.LoadScene("HomeScene");
    }

    public void replayButtonDown(){
        SceneManager.LoadScene("GameScene");
    }

}
