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
        Debug.Log("kinbenpoop " + controller);
        Debug.Log("kinbenpoop " + controller == null);
    }

    void OnGUI()
    {
        Debug.Log("shit");
        if (controller == null) return;
        Debug.Log(controller);
        Debug.Log(controller.horizontalSpeed.ToString("0.00"));
        GUI.Box(new Rect(10, 10, 80, 40), "Debug");
        GUI.Label(new Rect(25, 25, 100, 30), controller.horizontalSpeed.ToString("0.00"));
    }
}
