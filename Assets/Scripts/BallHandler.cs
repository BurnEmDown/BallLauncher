using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallHandler : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if (!Touchscreen.current.primaryTouch.press.isPressed) return;
        
        Vector2 touchPosition = Touchscreen.current.primaryTouch.position.ReadValue();
        
        Debug.Log(touchPosition);
    }
}
