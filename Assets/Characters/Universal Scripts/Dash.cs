using System;
using System.Collections;
using System.Collections.Generic;
using Developer.Jackson.PlayerRedo.Scripts;
using UnityEngine;

public class Dash : MonoBehaviour
{
    //References changeable in the Inspector
        //1. Reference to the hitbox object within the player prefab 
    [SerializeField] private BoxCollider hitbox;
        //2. Animation curve responsible for speed curve of the dash
    [SerializeField] private AnimationCurve lerpCurve;
    
    //Internal float variables responsible for the actual dash speed  frame-by-frame
    private float dashSpeed, dashSpeedLastFrame;
    //Bool that tracks if the current dash is past its peak speed
    private bool pastPeakSpeed;
    //Public floats that determine dash attributes (Default values NOT final)
    public float dashPeakSpeed = 15f;
    public float dashTime = 0.1f;
    public float force = 15f;

    //References to player stuff
    private InputProcessor input;
    private PlayerBase playerBase;
    private CharacterController characterController;
    private Animator anim;

    private void Start()
    {
        //Attaching player stuff references
        input = GetComponent<InputProcessor>();
        playerBase = this.GetComponent<PlayerBase>();
        anim = this.GetComponent<Animator>();
        characterController = this.GetComponent<CharacterController>();
        //Make hitbox inactive upon Player initialization
        hitbox.gameObject.SetActive(false);
    }

    private void Update()
    {
        /*
         Upon recieving "dash" input, this script checks the player's current state.
         If state is "idle" (0) or "move" (1), the DashFunction coroutine begins. 
         */
         
        if (playerBase.GetDash())
        {
            
            if (playerBase.GetState() == 0 || playerBase.GetState() == 1)
            {
                StartCoroutine(DashFunction());
            }
        }
    }

    public IEnumerator DashFunction()
    {
        //These lines run upon starting the Dash coroutine
        //Establish "startTime" as the time as of the coroutine's calling
        float startTime = Time.time;
        //Get directional input from the player
        Vector3 dashDir = new Vector3(playerBase.dir.x, 0, playerBase.dir.z).normalized;
        //We haven't passed peak speed yet bc the function just started
        pastPeakSpeed = false;
        //Set current player state to "Dash" (2)
        SetAnimState(2);

        //Do this until time goes past "dashTime"
        while (Time.time < startTime + dashTime)
        {
            //set dashSpeed to dashPeakSpeed * whatever point on the curve we're currently on
            dashSpeed = (dashPeakSpeed * (lerpCurve.Evaluate(Time.time - startTime)));
            
            //If we're still speeding up, allow the player to change their dash trajectory
            if (pastPeakSpeed == false)
            {
                dashDir = new Vector3(playerBase.dir.x, 0, playerBase.dir.z).normalized;
                //If we're not still speeding up, then set pastPeakSpeed to true
                if (dashSpeed < dashSpeedLastFrame)
                {
                    pastPeakSpeed = true;
                }
            }
            
            //Actual dash movement sent to the character controller
            characterController.Move(dashDir.normalized * dashSpeed * Time.deltaTime);
            //At the end of this frame, set whatever the current speed is so it can be checked next frame
            dashSpeedLastFrame = dashSpeed;
            yield return null;
        }
        //Once dash is over, return to base speed and return to player state "idle" (0)
        playerBase.ReturnToBaseSpeed();
        SetAnimState(0);
    }
    
    void EnableHitbox()
    {
        //Enables dash hitbox (Referenced in animation)
        hitbox.gameObject.SetActive(true);
    }
    
    void DisableHitbox()
    {
        //Disables dash hitbox (Referenced in animation)
        hitbox.gameObject.SetActive(false);
    }

    void SetAnimState(int newState)
    {
        //Sets given state in both animator and playerBase
        anim.SetInteger("playerState", newState);
        playerBase.SetState(newState);
    }

}
 