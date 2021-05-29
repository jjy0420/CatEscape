using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //PC버전 이동 스크립트
    void Update()
    {
        //키보드 방향키 입력
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //왼쪽화살표
            transform.Translate(-3, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //오른쪽 화살표
            transform.Translate(3, 0, 0);
        }
    }

    //모바일버전 이동 스크립트, UI버튼클릭
    public void LButtonDown()
    {
        transform.Translate(-3, 0, 0);
    }

    public void RButtonDown()
    {
        transform.Translate(3, 0, 0);
    }
}
