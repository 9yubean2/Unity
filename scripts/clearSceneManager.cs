using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clearSceneManager : MonoBehaviour
{
    public void homeButtonDown(){
        SceneManager.LoadScene("HomeScene");
    }

}
