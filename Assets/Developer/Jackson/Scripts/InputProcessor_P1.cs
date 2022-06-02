using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class InputProcessor_P1 : MonoBehaviour
{
    private Controls controls;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void Awake()
    {
        controls = new Controls();
    }
    
    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    public Vector2 input
    {
        get
        {
            return controls.PlayerControls.Movement.ReadValue<Vector2>();
        }
    }
    
    public bool dash
    {
        get
        {
            return controls.PlayerControls.Dodge.triggered;
        }
    }
    
    public bool swing1
    {
        get
        {
            return controls.PlayerControls.Swing1.triggered;
        }
    }
}
