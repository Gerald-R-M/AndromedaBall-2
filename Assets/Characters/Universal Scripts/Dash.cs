using System;
using System.Collections;
using System.Collections.Generic;
using Developer.Jackson.PlayerRedo.Scripts;
using UnityEngine;

public class Dash : MonoBehaviour
{
    [SerializeField] private BoxCollider hitbox;
    
    public float dashSpeed = 15f;
    public float dashTime = 0.1f;

    public float force = 15f;

    private InputProcessor input;
    private PlayerBase playerBase;
    private CharacterController characterController;
    private Animator anim;

    private void Start()
    {
        input = GetComponent<InputProcessor>();
        playerBase = this.GetComponent<PlayerBase>();
        anim = this.GetComponent<Animator>();
        characterController = this.GetComponent<CharacterController>();
        hitbox.gameObject.SetActive(false);
    }

    private void Update()
    {
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
        float startTime = Time.time;
        Vector3 dashDir = new Vector3(playerBase.dir.x, 0, playerBase.dir.z).normalized;
        Debug.Log("dashDir: " + dashDir.ToString()); 
        SetAnimState(2);

        while (Time.time < startTime + dashTime)
        {
            characterController.Move(dashDir.normalized * dashSpeed * Time.deltaTime);
            yield return null;
        }
        playerBase.ReturnToBaseSpeed();
        SetAnimState(0);
    }
    
    void EnableHitbox()
    {
        hitbox.gameObject.SetActive(true);
    }
    
    void DisableHitbox()
    {
        hitbox.gameObject.SetActive(false);
    }

    void SetAnimState(int newState)
    {
        anim.SetInteger("playerState", newState);
        playerBase.SetState(newState);
    }

}
 