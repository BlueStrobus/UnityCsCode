using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject player;
    void Start()
    {
        this.player = GameObject.Find("Owl");
    }

    void Update()
    {
        // 화살을 프레임마다 등속으로 낙하시킵니다.(플레이어에서 1초에 60프레임으로 제한걸었습니다.)
        transform.Translate(0, -0.1f, 0);


        // 화면 밖으로 나간 화살을 제거합니다.
        if (transform.position.y < -9.0f ) // 게임 화면에 맞게 조절하세요
        { 
            Destroy(gameObject);
            // Destroy
            // 사용 예시 : void Object.Destroy(Object obj, float t)
            // Removes a GameObject, component or asset.
        }

        // 충돌 판정
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        // Debug.Log(dir);
        float d = dir.magnitude;

        if(d< 1)
        {
            // director스크립트에 화살과 부엉이가 충돌했음을 전함
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GaimDirectorOwl>().DecreaseHp();

            Debug.Log("충돌");
            // 충돌할 경우 화살을 지웁니다.
            Destroy(gameObject);
        }
    }

}