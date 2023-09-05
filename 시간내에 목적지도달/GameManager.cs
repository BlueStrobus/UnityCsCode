using System.Collections;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject destination; // 목적지 오브젝트 (Collider 컴포넌트가 추가되어 있어야 함)
    public float timeLimit = 10.0f; // 제한 시간
    public GameObject countdownUI; // 카운트다운 UI 오브젝트
    public TextMeshProUGUI resultText; // 결과를 표시할 TMP 텍스트 컴포넌트
    public PlayerController playerController;
    private bool isGameEnded = false;

    private void Start()
    {
        countdownUI.SetActive(false); // 카운트다운 UI 비활성화
        resultText.gameObject.SetActive(false); // 결과 텍스트 오브젝트 비활성화
        StartCoroutine(StartCountdown());
    }

    public IEnumerator StartCountdown()
    {
        yield return new WaitForSeconds(3.0f); // 3초 대기

        countdownUI.SetActive(true); // 카운트다운 UI 활성화

        TextMeshProUGUI timerText = countdownUI.GetComponent<TextMeshProUGUI>(); // 카운트다운 UI에서 TMP 텍스트 컴포넌트 가져오기

        timerText.text = timeLimit.ToString("F1");

        float elapsedTime = 0.0f;

        while (elapsedTime < timeLimit && isGameEnded == false)
        {
            elapsedTime += Time.deltaTime;
            float remainingTime = Mathf.Max(0.0f, timeLimit - elapsedTime);
            timerText.text = remainingTime.ToString("F1");
            yield return null;
        }

        if (isGameEnded == false)
        {
            EndGame("Time's up!");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
        if (other.CompareTag("Player") && destination != null && isGameEnded == false)
        {
            EndGame("Destination reached!");
        }
    }

    public void EndGame(string message)
    {
        isGameEnded = true;
        playerController.canMove = false;
        countdownUI.SetActive(false); // 카운트다운 UI 비활성화
        resultText.gameObject.SetActive(true);
        resultText.text = message;
    }
}
