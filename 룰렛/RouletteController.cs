using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{

    float rotSpeed = 0; //회전속도

    // Start is called before the first frame update
    void Start()
    {
        // 프레임레이트를 60으로 고정( 1초에 60 프레임)
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        // 클릭할 때 회전속도 설정
        if(Input.GetMouseButtonDown(0)) // 0은 왼쪽, 1은 오른쪽 마우스
        {// 이 스크립트의 rotSpeed 변수

            // this.rotSpeed = 10; // 누를때 마다 속도 10으로 초기화
            this.rotSpeed += 10; // 여러번 누를수록 속도 증기
            
            
        }
        // 손가락 슬라이드, 방향
        // 오래 누를수록 속도 증가




        // 화전 속도 만큼 룰렛 회전시킴
        transform.Rotate(0,0, this.rotSpeed);
        // 룰렛 감속
        this.rotSpeed *= 0.95f;
    }
}
