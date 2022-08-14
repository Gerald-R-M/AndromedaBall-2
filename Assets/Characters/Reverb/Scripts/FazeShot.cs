using System;
using System.Collections;
using System.Collections.Generic;
using Developer.Jackson.PlayerRedo.Scripts;
using UnityEngine;

public class FazeShot : Ability
{
    private Movement _movementRef;
    private bool IsFazeActive = false;
    private bool isColliding = false;
    private float _activeCounter;
    private float _collisionCounter;
    private float _speedRef;

    
    
    /// <summary>
    /// Serialized Fields
    /// </summary>
    [SerializeField]
    private Collider Hitbox;
    [SerializeField]
    private float FazeActiveTime = 3.0f;
    [SerializeField]
    private float FazeCollisionTime = 3.0f;
    [SerializeField]
    private FazeShotCollision _collisionRef;
    [SerializeField]
    private float FazeMultiplier = 2f;
    [SerializeField]
    private GameObject PHFeedback;
    // Start is called before the first frame update
    
    public override void Activate()
    {
        ActivateFazeShot();
    }

    // Update is called once per frame
    private void ActivateFazeShot()
    {
        if (!IsFazeActive)
        {
            Debug.Log("Faze Shot Activated!");
            PHFeedback.SetActive(true);
            Hitbox.enabled = true;
            IsFazeActive = true;
        }
        else
        {
            EndFazeShot();
        }
        
    }
    private void Update()
    {
        if (IsFazeActive && FazeActiveTime > _activeCounter && !isColliding)
        {
            _activeCounter += Time.deltaTime;
        }
        else if (isColliding && FazeCollisionTime > _collisionCounter)
        {
            _collisionCounter += Time.deltaTime;
        }
        else
        {
            EndFazeShot();
        }
    }
    public void FazeShotTriggered()
    {
        GetComponent<PlayerBase>().speed = 0;
        isColliding = true;
    }

    public void EndFazeShot()
    {
        Debug.Log("Faze Shot Ended!");
        PHFeedback.SetActive(false);
        GetComponent<PlayerBase>().ReturnToBaseSpeed();
        Hitbox.enabled = false;
        IsFazeActive = false;
        isColliding = false;
        _activeCounter = 0f;
        _collisionCounter = 0f;
        _collisionRef.UnfazeBall();
    }
    public float GetMultiplier()
    {
        return FazeMultiplier;
    }
}
