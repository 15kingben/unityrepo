using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugInfo : MonoBehaviour
{
    private PlayerController controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<PlayerController>();
    }

    void OnGUI()
    {
        if (controller == null) return;
        Debug.Log(controller);
        Debug.Log(controller.horizontalSpeed.ToString("0.00"));
        GUI.Box(new Rect(10, 10, 100, 100), "Debug");
        GUI.Label(new Rect(20, 30, 80, 30), controller.horizontalSpeed.ToString("0.00"));
        GUI.Label(new Rect(20, 60, 80, 30), controller.status.ToString());
    }
}
