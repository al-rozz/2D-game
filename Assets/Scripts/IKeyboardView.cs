using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void KeyPressedHandler();
public interface IKeyboardView
{
    event KeyPressedHandler attackPressed;
}
