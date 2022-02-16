using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform childTransform;  // ������ �ڽ� ���� ������Ʈ�� Ʈ������
    // Start is called before the first frame update
    void Start()
    {
         transform.position = new Vector3(0, -1, 0); // �ڽ��� ������ġ�� 0 ,-1,0 ���� ����

        childTransform.localPosition = new Vector3(0, 2, 0); //�ڽ��� ������ġ�� 0 ,2, 0 ���� ����

        transform.rotation = Quaternion.Euler(new Vector3(0, 0, 30)); //�ڽ��� ȸ���� 0, 0 ,30 ���� ���� 
        childTransform.localRotation = Quaternion.Euler(new Vector3(0, 60, 0)); // �ڽ��� ���� ȸ���� 0, 60 ,0���� ����


    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime); //��Ű �ʴ�  0 , 1 ,0�� �ӵ��� �����̵�

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime);//�Ʒ�Ű �ʴ�  0 , -1 ,0�� �ӵ��� �����̵�

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, 0, 180) * Time.deltaTime);
            childTransform.Rotate(new Vector3(0, 0, 180) * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate (new Vector3(0, 0, -180) * Time.deltaTime);
            childTransform.Rotate(new Vector3(0, 0, -180) * Time.deltaTime);

        }
    }
}
