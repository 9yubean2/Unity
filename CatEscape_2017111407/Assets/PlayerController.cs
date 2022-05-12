using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void LButtonDown()
    {
        transform.Translate(-2, 0, 0); //move left to 2
    }

    public void RButtonDown()
    {
        transform.Translate(2, 0, 0); //move right to 2
    }
    // Update is called once per frame
    void Update()
    {
        //left
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-2, 0, 0); //move left to 2
        }

        //right
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(2, 0, 0); //move right to 2
        }
    }
}
