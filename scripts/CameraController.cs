using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Mathf;

public class CameraController : MonoBehaviour
{
    GameObject cart;
    
    void Start()
    {
        //cart 오브젝트 찾기
        this.cart = GameObject.Find("cart");
    }

    // Update is called once per frame
    void Update()
    {
        //카메라 이동 범위 제한 (x좌표 -42~0)
        Vector3 cartPos = this.cart.transform.position;
        cartPos.x = Clamp(cartPos.x, -42, 0);
        transform.position = new Vector3(
            cartPos.x, 0, -10);
    }
}