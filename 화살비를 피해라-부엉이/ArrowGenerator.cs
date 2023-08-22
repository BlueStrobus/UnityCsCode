using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefeb; // 화살 프리팹을 저장할 변수
    float span = 1.0f; // 화살 생성 간격
    float delta = 0; // 누적 시간을 저장할 변수

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime; // 누적 시간 갱신
        // Time.deltaTime
        // 

        // 일정 간격마다 화살 생성
        if (this.delta > this.span)
        {
            this.delta = 0; // 누적 시간 초기화
            GameObject go = Instantiate(arrowPrefeb);
            // 화살 프리팹을 복제하여 새로운 GameObject 생성
            int px = Random.Range(-15, 15);
            // 화면 좌우 끝에서 랜덤한 x 좌표 선택
            go.transform.position = new Vector3(px, 9, 0);
            // 생성한 화살의 위치 설정 (화면 위쪽 밖)
        }
    }
}
