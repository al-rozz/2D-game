using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class CharacterStateBase : StateMachineBehaviour
{
    public List<StateData> Abilities = new List<StateData>();

    //private CharacterController character_controller;

    //public CharacterController GetCharacterController(Animator animator)
    //{
    //    if (character_controller == null)
    //    {
    //        character_controller = animator.GetComponent<CharacterController>();
    //    }

    //    return character_controller;
    //}

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        foreach (StateData data in Abilities)
        {
            data.UpdateAbility(this, animator);
        }
    }

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        foreach (StateData data in Abilities)
        {
            data.OnEnter(this, animator);
        }
    }

    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        foreach (StateData data in Abilities)
        {
            data.OnExit(this, animator);
        }
    }
}
