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

    private IKeyboardView keyboardView;
    public void Initialise(IKeyboardView newKeyboardView)
    {
        keyboardView = newKeyboardView;

        
    }

    public void Uninitialise()
    {
        
    }

    
}