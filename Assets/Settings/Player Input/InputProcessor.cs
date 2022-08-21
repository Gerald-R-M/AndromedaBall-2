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
            return controls.PlayerControls.P1_Movement.ReadValue<Vector2>();
        }
    }

    public Vector2 input2
    {
        get
        {
            return controls.PlayerControls.P2_Movement.ReadValue<Vector2>();
        }
    }

    //Process dash input
    public bool p1_ability1
    {
        get
        {
            return controls.PlayerControls.P1_Ability1.triggered;
        }
    }
    
    public bool p1_ability2
    {
        get
        {
            return controls.PlayerControls.P1_Ability2.triggered;
        }
    }

    public bool p2_ability1
    {
        get
        {
            return controls.PlayerControls.P2_Ability1.triggered;
        }
    }
    
    public bool p2_ability2
    {
        get
        {
            return controls.PlayerControls.P2_Ability2.triggered;
        }
    }

    public bool p1_dash
    {
        get
        {
            return controls.PlayerControls.P1_Dash.triggered;
        }
    }

    public bool p2_dash
    {
        get
        {
            return controls.PlayerControls.P2_Dash.triggered;
        }
    }
}
