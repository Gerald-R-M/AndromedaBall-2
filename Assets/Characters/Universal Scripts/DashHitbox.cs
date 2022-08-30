using System.Collections;
using System.Collections.Generic;
using Developer.Jackson.PlayerRedo.Scripts;
using UnityEngine;

public class DashHitbox : MonoBehaviour
{
    /// <summary>
    /// Attaches to the actual hitbox object within the player prefab.
    /// Recives info about how it should act from the base player prefab, and implements this when colliding with ball.
    /// </summary>
    
    //Ref to actual collider
    private BoxCollider collider;
    //Ref to "Dash" script attached to base player
    private Dash dashData;
    //Holds velocity of ball when they collide
    private float velRef;

    private ballSpeedManager _ballSpeedRef;
    
    void Start()
    {
        //Attach to refs
        collider = GetComponent<BoxCollider>();
        dashData = collider.transform.root.GetComponent<Dash>();
        _ballSpeedRef = FindObjectOfType<ballSpeedManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        //When the hitbox connects with the ball
        if (other.gameObject.CompareTag("Ball"))
        {
            //Set velRef to the ball's current speed
            velRef = other.GetComponent<Rigidbody>().velocity.magnitude;
            //Set the direction we're gonna send the ball in to the Player's current facing direction
            //Multiply the direction vector to the "force" value in the Player's "Dash" variable
            Vector3 newDirection = (transform.root.GetComponent<PlayerBase>().dir) * (dashData.force);
            
            //Add the force of "newDirection" to the ball
            //other.GetComponent<Rigidbody>().AddForce(newDirection, ForceMode.VelocityChange);
            _ballSpeedRef.CalculateVelocity(newDirection, dashData.force);
        }
    }
}
