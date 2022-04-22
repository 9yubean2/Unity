using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//player class
public class Player
{
    private int hp = 100;
    private int power = 50;

    public void Attack()
    {
        Debug.Log(this.power + "Hit Damage");
        Debug.Log("Now HP: " + this.hp);
    }

    public void Damage(int damage)
    {
        this.hp -= damage;
        Debug.Log(damage + "Get Damage");
        Debug.Log("Now HP: " + this.hp);
    }

}



public class Test : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
       Vector2 startPos = new Vector2(3.0f, 4.0f);
       Vector2 endPos = new Vector2(19.0f, 7.0f);
       Vector2 dir = endPos - startPos;

       Debug.Log(dir);

       float len = dir.magnitude;
       Debug.Log(len);

    }

    // Update is called once per frame
    void Update()
    {
        //Move object in every frame
    }
}
