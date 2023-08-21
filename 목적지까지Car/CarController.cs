using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        // 스와이프한 길이 구합니다.
        if (Input.GetMouseButtonDown(0))
        {
            // 마우스를 클릭한 좌표 입니다.
            this.startPos = Input.mousePosition;
            // mousePosition
            //  사용 예시 : Vector3 Input.mousePosition (get)
            // The current mouse position in pixal coordinates.(Read Only)
            // 픽셀 좌표의 현재 마우스 위치입니다.(읽기 전용)
        }

        else if (Input.GetMouseButtonUp(0))
        {
            // 마우스 버튼에서 손가락을 떼었을 때 좌표
            Vector2 endPos = Input.mousePosition;

            float swipeLength = endPos.x - startPos.x; // x좌표로만 계산

            // 스와이프한 거리를(x좌표사이의거리) 속도로 변경합니다.
            this.speed = swipeLength / 500.0f; // 좁으니까 속력 줄이기

            // 효과음을 재생합니다.
            GetComponent<AudioSource>().Play();
        }

        transform.Translate(this.speed, 0, 0); // 이동, 자동차 방향에 맞게 바꿔주세요
        // Translate
        // 사용 예시 : void Transform.Tramslate(Vector3 translation, Spave relativeTo)(+ 5 오버로드)
        // Moves the transform in the direction and distance of translation.
        // 이동 방향과 이동 거리로 변환을 이동합니다.
        this.speed *= 0.95f; // 감속
    }
}