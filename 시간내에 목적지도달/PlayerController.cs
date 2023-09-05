using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 15.0f;
    public bool canMove = false;

    public GameManager gameManager; // GameManager 스크립트 타입으로 변경

    private void Update()
    {
        if (canMove)
        {
            Debug.Log("Move");
            // 플레이어의 수평 및 수직 입력을 받음
            float horizontalInput = Input.GetAxisRaw("Horizontal");
            float verticalInput = Input.GetAxisRaw("Vertical");

            // 입력을 정규화하여 움직임 방향 계산
            Vector3 moveDirection = new Vector3(horizontalInput, 0, verticalInput).normalized;
            Vector3 movement = moveDirection * moveSpeed * Time.deltaTime;

            // 플레이어 위치 업데이트
            transform.Translate(movement);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == gameManager.destination) // && gameManager.IsGameEnded == true )
        {
            Debug.Log("Destination reached!");
            gameManager.EndGame("Destination reached!");
        }
    }
}
