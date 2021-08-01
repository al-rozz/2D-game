using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardView : MonoBehaviour, IKeyboardView
{
    public KeyCode attackButton { get; private set; }
    public KeyCode moveLeftButton { get; set; }
    public KeyCode moveRightButton { get; set; }
    public KeyCode jumpButton { get; set; }

    public event KeyPressedHandler attackPressed;

    void Update()
    {
        if (Input.GetKeyDown(attackButton))
        {
            attackPressed();
        }

        if (Input.GetKey(moveLeftButton))
        {
            
        }

        if (Input.GetKey(moveRightButton))
        {
            
        }

        if (Input.GetKeyDown(jumpButton))
        {
            
        }
    }
}
