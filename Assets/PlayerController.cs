using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //PC���� �̵� ��ũ��Ʈ
    void Update()
    {
        //Ű���� ����Ű �Է�
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //����ȭ��ǥ
            transform.Translate(-3, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //������ ȭ��ǥ
            transform.Translate(3, 0, 0);
        }
    }

    //����Ϲ��� �̵� ��ũ��Ʈ, UI��ưŬ��
    public void LButtonDown()
    {
        transform.Translate(-3, 0, 0);
    }

    public void RButtonDown()
    {
        transform.Translate(3, 0, 0);
    }
}
