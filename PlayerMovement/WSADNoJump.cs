// "Horizontal", "Vertical" ??

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WSADNoJump : MonoBehaviour
{

    public float newHP = 100;
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(h, 0, v) * 5f * Time.deltaTime);
    }
}