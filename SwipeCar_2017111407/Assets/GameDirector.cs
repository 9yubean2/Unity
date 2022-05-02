using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UI 사용시 필요

public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;

    // Start is called before the first frame update
    void Start()
    {
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
    
    }

    // Update is called once per frame
    void Update()
    {
        float length = this.flag.transform.position.x - this.car.transform.position.x;
        if (length > 0)
        {
            this.distance.GetComponent<Text>().text = "목표 지점까지" + length.ToString("F2")+"m";
        }
        else if (length == 0)
        {
            //수정3) 깃발에 맞춰 정확하게 도착했을 때의 UI
             this.distance.GetComponent<Text>().text = "당신은 운전의 신?";
        }
        else
        {
            this.distance.GetComponent<Text>().text = "그만 가세요!";
        }
        
        
        
    }
}
