using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using UnityEngine;

public class KeyBoardPresenterForModel : MonoBehaviour
{
    [SerializeField]
    private GameObject character;

    [SerializeField]
    private Movement movementModel;

    private IKeyboardView keyboardView;
    public void Initialize(IKeyboardView newKeyboardView)
    {
        keyboardView = newKeyboardView;

        keyboardView.moveLeftPressed += OnMoveLeftButtonClicked;
        keyboardView.moveRightPressed += OnMoveRightButtonClicked;
        keyboardView.jumpButtonPressed += OnJumpButtonClicked;

        movementModel.character = character;
    }

    public void Uninitialize()
    {
        keyboardView.moveLeftPressed -= OnMoveLeftButtonClicked;
        keyboardView.moveRightPressed -= OnMoveRightButtonClicked;
        keyboardView.jumpButtonPressed -= OnJumpButtonClicked;
    }

    private void OnMoveLeftButtonClicked()
    {
        movementModel.MoveLeft();
    }

    private void OnMoveRightButtonClicked()
    {
        movementModel.MoveRight();
    }

    private void OnJumpButtonClicked()
    {
        movementModel.Jump();
    }
}