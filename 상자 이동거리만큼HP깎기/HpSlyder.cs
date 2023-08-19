using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpSlyder : MonoBehaviour
{

    Slider slHP;

    GameObject player;
    Player playerSc;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("Player");
        playerSc = player.GetComponent<Player>();

        slHP = GetComponent<Slider>();
    }

    private void Update()
    {
        UpdateHP();
    }
    public void UpdateHP()
    {
        // Update the slider value based on player's HP
        this.slHP.GetComponent<Slider>().value = playerSc.newHP;

        Debug.Log(playerSc.newHP);
    }
}