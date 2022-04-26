using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; //회전 속도
     
    
    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        //클릭하면 회전 속도를 설정한다.
        
        //수정1) 클릭하고 있으면 회전속도 유지
        if (Input.GetMouseButton(0))
        {
            //수정2) 회전 속도 증가
            this.rotSpeed = 15;
        }

        //회전 속도만큼 룰렛을 회전시킨다.
        transform.Rotate(0, 0, this.rotSpeed);
        //수정1) 마우스 클릭 떼면 회전 감속
        //수정2) 감속 계수 변경
        this.rotSpeed *= 0.94f;
    }
}