using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGUItest1 : MonoBehaviour
{
    private void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 150, 100), "My Button"))
        {
            Debug.Log("click1!");
        }
        
        // 1024 - 160 = 864, 비율 달라지면 위치 달라짐, 불편  
        if (GUI.Button(new Rect(864, 10, 150, 100), "Click Button"))
        {
            Debug.Log("click2!");
        }
    }
}ㅂㅓ
