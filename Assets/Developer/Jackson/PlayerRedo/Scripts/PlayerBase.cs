using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Movement))]
[RequireComponent(typeof(InputProcessor))]
public class PlayerBase : MonoBehaviour
{
    public int playerIndex;
    [HideInInspector]
    public CharacterController controller;
    [HideInInspector]
    public float speed;

    private InputProcessor playerInput;

    private float xInput, yInput;
    private bool dash, swing;
    
    public float baseSpeed;
    public float sprintSpeed;

    public Ability ability1;
    public Ability ability2;

    [HideInInspector]
    public Vector3 dir;
    

    
    // Start is called before the first frame update
    void Start()
    {
        controller = this.GetComponent<CharacterController>();
        playerInput = this.GetComponent<InputProcessor>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIndex == 1)
        {
            xInput = playerInput.input.x;
            yInput = playerInput.input.y;
            dash = playerInput.dash;
            swing = playerInput.swing1;
        }

        else if (playerIndex == 2)
        {
            xInput = playerInput.input2.x;
            yInput = playerInput.input2.y;
            dash = playerInput.dash2;
            swing = playerInput.swing2;
        }
        
        dir = new Vector3(xInput, 0, yInput).normalized;

    }
}
