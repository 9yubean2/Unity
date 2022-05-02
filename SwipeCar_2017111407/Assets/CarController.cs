using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;
    Vector2 starPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //스와이프 길이를 구한다
        if (Input.GetMouseButtonDown(0))
        {
            //this.speed = 0.2f;
            //마우스를 클릭한 좌표
            this.starPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            //마우스 버튼에서 손가락을 뗴었을 때 좌표
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - this.starPos.x;

            //수정1) 차가 왼쪽으로 이동할 수 없게 설정
            if (swipeLength < 0)
            {
                //Debug.Log("역주행 금지!");
                this.speed = 0;
            }
            else
            {
                //스와이프 길이로 속도 설정
                //수정2) 너무 많이 이동하는 것 같아서 500->650으로 수정
                this.speed = swipeLength / 650.0f;
            }
            //스와이프하면 효과음 재생
            GetComponent<AudioSource>().Play();
        }
        //이동
        transform.Translate(this.speed, 0, 0);
        //감속
        this.speed *= 0.98f;
    }
}
