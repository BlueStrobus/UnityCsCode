using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEditor.UI;

public class GameDirectorCar : MonoBehaviour
{
    GameObject car;
    GameObject goal;
    GameObject distance;
    bool gameOver = false;
    // Start is called before the first frame update
     void Start()
    {// 하이라키에 있는 해당 객체의 이름을 적습니다.
        this.car = GameObject.Find("car");
        this.goal = GameObject.Find("goal");
        this.distance = GameObject.Find("distance");
    }
   

    // Update is called once per frame
    // Update is called once per frame
    void Update()
    {
        float length = this.goal.transform.position.x - this.car.transform.position.x;
        // transform은 GetComponent<Transform>과 같습니다.

        if (length > 0.6f)
        {
            // TMP의 텍스트 수정
            this.distance.GetComponent<TextMeshProUGUI>().text = "Distance: " + length.ToString("F2") + "m";
            // ~.ToString("F2")  소숫점 둘째자리까지 표시
        }
        else if (length > -1 && length <= 0.6)
        {
            this.distance.GetComponent<TextMeshProUGUI>().text = "Win!";
            gameOver = true;
        }
        else
        {
            this.distance.GetComponent<TextMeshProUGUI>().text = "Game Over";
            gameOver = true;
        }
    }
}
