using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{

    public GameObject arrowPrefab;  //화살 프리팹 변수선언
    float span = 1.0f;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //프레임과 프레임 사이의 시간 차이를 Time.deltaTime에 모은다
        
        this.delta += Time.deltaTime;
        if (this.delta > this.span) //모은 시간이 1초가 넘는지 this.span으로 구분
        { 
            this.delta = 0;         //1초가 되면 Time.deltaTime을 비운다.
            GameObject go = Instantiate(arrowPrefab) as GameObject;
            int px = Random.Range(-6, 7); //화살이 생성되는 범위
            go.transform.position = new Vector3(px, 7, 0); //
        }
    }
}