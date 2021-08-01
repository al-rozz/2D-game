using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Idle State", menuName = "States/Idle")]
public class Idle : StateData
{
    public override void OnEnter(CharacterStateBase characterStateBase, Animator animator)
    {
        
    }

    public override void OnExit(CharacterStateBase characterStateBase, Animator animator)
    {
        animator.ResetTrigger("Move");
    }

    public override void UpdateAbility(CharacterStateBase characterStateBase, Animator animator)
    {
        if (Input.GetKey(KeyCode.A)
            || Input.GetKey(KeyCode.D)
            || Input.GetKey(KeyCode.Space))
        {
            animator.SetTrigger("Move");
        }
    }
}
