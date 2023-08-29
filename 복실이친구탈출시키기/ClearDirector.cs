using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;// 씬 전환 시 필수

public class ClearDirector : MonoBehaviour
{ // 종료씬 -> 게임"
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("FurBall"); // 게임씬의 이름을 넣으세요
        }
    }
}
