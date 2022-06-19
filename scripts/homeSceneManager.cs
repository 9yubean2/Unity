using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class homeSceneManager : MonoBehaviour
{
 
    //play버튼을 누르면 GameScene으로 이동
    public void playButtonDown(){
        SceneManager.LoadScene("GameScene");
    }
    //howtoplay버튼을 누르면 howToPlayScene으로 이동
    public void howtoplayButtonDown(){
        SceneManager.LoadScene("howToPlayScene");
    }

}
