using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody playerRigidbody;
    public float speed; // 이동속도
    float newSpeed;

    private void Start()
    {
        // 컴포넌트 알아서 찾으라고 적어놓/
        playerRigidbody = GetComponent<Rigidbody>(); 
    }
    void Update()
    {
        // 수평축과 수직축의 입력값을 감지하여 저장
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.LeftShift) == false && Input.GetKey(KeyCode.RightShift) == false)
        {
            newSpeed = speed;
        }
        if (Input.GetKey(KeyCode.LeftShift) == true || Input.GetKey(KeyCode.RightShift) == true)
        {
           newSpeed = 2 * speed;
        }

        // 실제 이동속도를 입력값과 이동속도를 사용해 결정
        float xSpeed = xInput * newSpeed;
        float ySpeed = yInput * newSpeed;

        // Vector 속도를 (xSpeed, 0, ySpeed)로 생성
        Vector3 newVelocity = new Vector3(xSpeed, 0, ySpeed);
        // Rigidbody의 속도에 newVelocity 할당
        playerRigidbody.velocity = newVelocity;
    }

    public void Over()
    { // 자신(플레이어)의 게임 오브젝트 비활성화
        gameObject.SetActive(false);
    }
}
