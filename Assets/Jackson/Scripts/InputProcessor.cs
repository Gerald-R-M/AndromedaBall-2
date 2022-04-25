using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class InputProcessor : MonoBehaviour
{
    private Controls controls;

    void Awake()
    {
        controls = new Controls();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //Methods to enable and disable player input
    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }


    //Process basic player movement (WASD)
    public Vector2 input
    {
        get
        {
            return controls.PlayerControls.Movement.ReadValue<Vector2>();
        }
    }

    public Vector2 input2
    {
        get
        {
            return controls.PlayerControls.Movement2.ReadValue<Vector2>();
        }
    }

    //Process dash input
    public bool dash
    {
        get
        {
            return controls.PlayerControls.Dodge.triggered;
        }
    }

    public bool dash2
    {
        get
        {
            return controls.PlayerControls.Dodge2.triggered;
        }
    }

    public bool swing1
    {
        get
        {
            return controls.PlayerControls.Swing1.triggered;
        }
    }
    public bool swing2
    {
        get
        {
            return controls.PlayerControls.Swing2.triggered;
        }
    }
}
