using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
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
        transform.Translate(0, -0.1f, 0);

        //화면 밖으로 나오면 오브젝트를 소멸시킨다.
        if(transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        //충돌판정 구현
        Vector2 p1 = transform.position;                //화살 중심 좌표
        Vector2 p2 = this.player.transform.position;    //플레이어의 중심 좌표
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;                                //화살 반경
        float r2 = 1.0f;                                //플레이어의 반경

        if(d < r1 + r2)
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();

            //충돌 시 화살을 지움
            Destroy(gameObject);
        }
    }
}
