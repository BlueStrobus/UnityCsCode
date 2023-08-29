using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;// 씬 전환 시 필수

public class BallController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    float jumpForce = 500.0f; // 재생해보고 수정하세요
    float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // 점프
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigid2D.AddForce(transform.up * jumpForce);
        }

        // 좌우 이동
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        // 플레이어의 속도
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);
        // Mathf
        // 사용방법 : struct UnityEngine.Mathf
        // A collection of common math functions. 일반적인 수학 함수 모음입니다.
        // Mathf.Ab
        // 사용 : float Mathf.Abs(float f)
        // Returns the absolute value of f. f의 절대값을 반환합니다.
        // velocity
        // 사용 : Vector2 Rigidbody2D.velocity { get; set;}
        // Linear velocity of the Rigidbody in units per second.
        // 초당 단위로 표시되는 강체의 선형 속도입니다.

        // 스피드 제한
        if (speedx < maxWalkSpeed)
        {
            rigid2D.AddForce(transform.right * key * walkForce);
        }

        // 움직이는 방향에 따라 좌우 반전
        if (key != 0)
        {
            transform.localScale = new Vector3(0.4f * key, 0.4f, 0.4f);
         // transform.localScale : x축 크기에 1,-1로 설정를 하여 좌우 반전이 되도록 합니다 
        }
    }

    // 끝 도착
    // 게임 -> 종료 씬
    void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("ClearScene"); // 게임씬의 이름을 넣으세요
    }
}