using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 씬 이동

public class GameManager : MonoBehaviour
{
    public GameObject winUI;
    public ItemBox[] itemBoxes;
    public bool isGameOver;

    void Start()
    {
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            SceneManager.LoadScene("Cube");
        }

        if(isGameOver == true)
        {
            return;
        }

        int count = 0;
        for (int i = 0 ; i < 4; i++) // 도착지 수에따라 달라짐 
        {   // ItemBox.cs에 public bool isOveraped = false; 추가
            if (itemBoxes[i].isOveraped == true)
            {
                count++;
                Debug.Log("+1");
            }
        }

        if(count >= 4)
        {
            Debug.Log("게임 승리!");
            isGameOver = true;
            winUI.SetActive(true);// UI활성
        }
    }
}
