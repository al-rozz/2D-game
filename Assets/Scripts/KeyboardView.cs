using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardView : MonoBehaviour, IKeyboardView
{
    [SerializeField]
    private KeyBoardPresenterForModel presenter;

    public KeyCode attackButton { get; set; }
    public KeyCode moveLeftButton { get; set; }
    public KeyCode moveRightButton { get; set; }
    public KeyCode jumpButton { get; set; }

    public event KeyPressedHandler attackPressed;
    public event KeyPressedHandler moveRightPressed;
    public event KeyPressedHandler moveLeftPressed;
    public event KeyPressedHandler jumpButtonPressed;

    void Start()
    {
        presenter.Initialize(this);

        attackButton = KeyCode.Mouse0;
        moveLeftButton = KeyCode.A;
        moveRightButton = KeyCode.D;
        jumpButton = KeyCode.Space;
    }

    void Update()
    {
        if (Input.GetKeyDown(attackButton))
        {
            attackPressed();
        }

        if (Input.GetKey(moveLeftButton))
        {
            moveLeftPressed();
        }

        if (Input.GetKey(moveRightButton))
        {
            moveRightPressed();
        }

        if (Input.GetKeyDown(jumpButton))
        {
            jumpButtonPressed();
        }
    }

    void OnDestroy()
    {
        presenter.Uninitialize();
    }
}
