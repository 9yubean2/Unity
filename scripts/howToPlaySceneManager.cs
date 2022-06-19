using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class howToPlaySceneManager : MonoBehaviour
{

    public void playButtonDown(){
        SceneManager.LoadScene("GameScene");
    }
    public void homeButtonDown(){
        SceneManager.LoadScene("HomeScene");
    }

}
