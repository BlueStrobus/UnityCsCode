// WSAD������ �������� speed ���� �ۿ���
// speed�� ����Ƽ���� ���� ����(public)

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WSADGetKey : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody playerRigidbody;
    // Start is called before the first frame update

    // �����Ӵ� �ѹ� ����
    // Update is called once per frame
    void Update()
    {
        //�����Է�
        if(Input.GetKey(KeyCode.W)){
            playerRigidbody.AddForce(0,0,speed);
        }
        if(Input.GetKey(KeyCode.S)){
            playerRigidbody.AddForce(0,0,-speed);
        }
        if(Input.GetKey(KeyCode.D)){
            playerRigidbody.AddForce(speed,0,0);
        }
        if(Input.GetKey(KeyCode.A)){
            playerRigidbody.AddForce(-speed,0,0);
        }
        
    }
}


