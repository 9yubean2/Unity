using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Mathf;

public class CartController : MonoBehaviour
{


    //좌측 화살표를 누르면 -3만큼 이동
    public void LButtonDwon(){
        transform.Translate(-3, 0, 0);
        
    }

    //우측 화살표를 누르면 3만큼 이동
    public void RButtonDown(){
        transform.Translate(3, 0, 0);
        
    }
    
    void Update()
    {
        //카트 이동 범위 제한
        Vector3 worldpos = Camera.main.WorldToViewportPoint(this.transform.position);
        if (worldpos.x < 0f) worldpos.x = 0f;
        if (worldpos.y < 0f) worldpos.y = 0f;
        if (worldpos.x > 1f) worldpos.x = 1f;
        if (worldpos.y > 1f) worldpos.y = 1f;
        this.transform.position = Camera.main.ViewportToWorldPoint(worldpos);
    }
}
