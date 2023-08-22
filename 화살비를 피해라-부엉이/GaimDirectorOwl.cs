using UnityEngine;
using UnityEngine.UI;

public class GaimDirectorOwl : MonoBehaviour
{
    public Image hpGauge; // Change the variable type to Image

    // Start is called before the first frame update
    void Start()
    {
        // Make sure the HpGauge object is assigned in the Inspector
        if (hpGauge == null)
        {
            Debug.LogError("HpGauge is not assigned!");
        }
    }

    public void DecreaseHp() // Corrected the method name
    {
        // Decrease the fill amount by 0.1f, but make sure it doesn't go below 0
        hpGauge.fillAmount = Mathf.Max(hpGauge.fillAmount - 0.1f, 0f);
    }
}
