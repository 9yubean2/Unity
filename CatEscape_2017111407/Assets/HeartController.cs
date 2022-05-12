using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartController : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        //프레임마다 등속으로 낙하
        transform.Translate(0, -0.2f, 0);

        //화면 밖으로 나가면 오브젝트 소멸
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        //충돌 판정
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;

        if ( d < r1 + r2 )
        {
            //감독 스크립트에 플레이어가 하트를 획득했다고 전달
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().IncreaseHp();

            //충돌 시 heart 소멸
            Destroy(gameObject);
        }
    }
}
