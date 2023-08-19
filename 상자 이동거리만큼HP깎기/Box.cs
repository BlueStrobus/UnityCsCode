using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public float hp; // 깎을 hp
    public float distance; // 이동거리
    GameObject player;
    Player playerSc;
    Vector3 prevPos; // 처음 위치
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("Player");
        playerSc = player.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        // 위치 업데이트
        Vector3 pos = transform.position;
        Vector3 dis = prevPos - pos;
        playerSc.newHP -= hp * dis.magnitude;


        prevPos = pos;
    }
}
