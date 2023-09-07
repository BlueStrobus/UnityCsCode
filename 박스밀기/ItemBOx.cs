using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{

    public bool isOveraped = false;

    Renderer myRenderer;
    Color originalColor;
    public Color Color;
    
    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<Renderer>();
        originalColor = myRenderer.material.color; // 원래색 가져오기 
    }

    // Update is called once per frame
    void Update()
    {

    }

      
    private void OnTriggerEnter(Collider other)
    { // 닿은 순간
        if(other.tag == "Destination")
        {
            
            // myRenderer.material.color = Color.grey;// 변하는 색 코드에서 지정
            myRenderer.material.color = Color;// 인스펙터창에서 색 지정 
            isOveraped = true;
            Debug.Log("목적지 도착!");
        }
    }

    private void OnTriggerExit(Collider other)
    { // 떨어진 순간 
        if (other.tag == "Destination")
        {
            myRenderer.material.color = originalColor; // 색 복구 
        }        
    }

    private void OnTriggerStay(Collider other)
    { // 닿아있는 동안 
        if (other.tag == "Destination")
        {
            myRenderer.material.color = Color;
        }
    }


}
