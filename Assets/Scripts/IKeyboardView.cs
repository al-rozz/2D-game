using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void KeyPressedHandler();
public interface IKeyboardView
{
    event KeyPressedHandler attackPressed;
    event KeyPressedHandler moveRightPressed;
    event KeyPressedHandler moveLeftPressed;
    event KeyPressedHandler jumpButtonPressed;
}
