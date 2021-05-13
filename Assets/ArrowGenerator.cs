using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{

    public GameObject arrowPrefab;  //ȭ�� ������ ��������
    float span = 1.0f;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�����Ӱ� ������ ������ �ð� ���̸� Time.deltaTime�� ������
        
        this.delta += Time.deltaTime;
        if (this.delta > this.span) //���� �ð��� 1�ʰ� �Ѵ��� this.span���� ����
        { 
            this.delta = 0;         //1�ʰ� �Ǹ� Time.deltaTime�� ����.
            GameObject go = Instantiate(arrowPrefab) as GameObject;
            int px = Random.Range(-6, 7); //ȭ���� �����Ǵ� ����
            go.transform.position = new Vector3(px, 7, 0); //
        }
    }
}