using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    float rotateSpeed;

    void Update()
    {
        rotateSpeed = 60 * Time.deltaTime;
        float r = rotateSpeed;
        transform.Rotate(r, r, r);
    }
}