using System.Collections;
using UnityEngine;
using TMPro;

public class StartCountDown : MonoBehaviour
{
    public TextMeshProUGUI countdownText; // TMPro 텍스트 컴포넌트
    public float countdownDuration = 4.0f;
    public PlayerController playerController;

    private void Start()
    {
        StartCoroutine(StartCountdown());
    }

    private IEnumerator StartCountdown()
    {
        countdownText.text = "3";
        yield return new WaitForSeconds(1.0f);

        countdownText.text = "2";
        yield return new WaitForSeconds(1.0f);

        countdownText.text = "1";
        yield return new WaitForSeconds(1.0f);

        countdownText.text = "Start!";
        yield return new WaitForSeconds(1.0f);

        countdownText.gameObject.SetActive(false);

        playerController.canMove = true; // 이동 가능하게 설정
    }
}
