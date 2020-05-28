using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class MenuScript : MonoBehaviour
{

    public GameObject canvas;
    public List<XRController> controllers = null;
    private bool isPressed = false;

    // Update is called once per frame
    void FixedUpdate()
    {
        CheckForInput();
    }

    private void CheckForInput()
    {
        foreach (XRController controller in controllers)
        {
            if (controller.enableInputActions)
            {
                CheckForClick(controller.inputDevice);
            }
        }
    }

    private void CheckForClick(InputDevice device)
    {
        if (device.TryGetFeatureValue(CommonUsages.menuButton, out bool pressed))
        {
            if (pressed == true)
            {
                isPressed = true;
                OpenMenu(isPressed);
            }
        }
    }

    private void OpenMenu(bool pressed)
    {
        if (pressed)
        {
            canvas.SetActive(!canvas.activeSelf);
        } 
    }
}
