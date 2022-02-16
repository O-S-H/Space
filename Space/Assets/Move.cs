using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform childTransform;  // 움직일 자식 게임 오즈젝트의 트랜스폼
    // Start is called before the first frame update
    void Start()
    {
         transform.position = new Vector3(0, -1, 0); // 자신의 전역위치를 0 ,-1,0 으로 변경

        childTransform.localPosition = new Vector3(0, 2, 0); //자식의 지역위치를 0 ,2, 0 으로 변경

        transform.rotation = Quaternion.Euler(new Vector3(0, 0, 30)); //자신의 회전을 0, 0 ,30 으로 변경 
        childTransform.localRotation = Quaternion.Euler(new Vector3(0, 60, 0)); // 자식의 지역 회전을 0, 60 ,0으로 변경


    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime); //윗키 초당  0 , 1 ,0의 속도로 평행이동

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime);//아래키 초당  0 , -1 ,0의 속도로 평행이동

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
