using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCamera : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        // "Player"라는 이름을 가진 게임 오브젝트를 찾아 player 변수에 할당
        this.player = GameObject.Find("Player");
    }
    void Update()
    {
        // 플레이어의 위치를 가져옴
        Vector3 playerPos = this.player.transform.position;
        // 카메라의 위치를 업데이트하여 y축만 플레이어의 y축 위치와 일치하도록 함
        transform.position = new Vector3(
            transform.position.x, playerPos.y, transform.position.z);
    }
}
