using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballSpeedManager : MonoBehaviour
{
    public float currentVelocity; //TODO change this to private after testing is complete
    private float maxVelocity; //Stores the velocity the ball is traveling at the end of the acceleration calculation
    private float sustainVelocity; //Stores the velocity the ball should sustain after peeking at max velocity
    private Rigidbody rigidRef;
    private bool ballCollided = false;
    private float startingDrag; //stores the drag the ball is set to so that the ball's velocity can be maintained
    [SerializeField, Tooltip("How many frames should the ball accelerate before reaching max velocity")] private float accelerationTime = 10f;
    [SerializeField, Tooltip("What percentage of the ball's max velocity should the ball sustain? Input as a decimal for example 80% would be 0.8")]
    private float sustainPercent = 0.80f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rigidRef = GetComponent<Rigidbody>();
        startingDrag = rigidRef.drag;
    }

    // Update is called once per frame
    void Update()
    {
        currentVelocity = rigidRef.velocity.magnitude; //TODO here to show current velocity in inspector for debugging. Remove upon completed implementation
        if (currentVelocity < sustainVelocity)
        {
            MaintainVelocity();
        }
    }
    /// <summary>
    /// Called by "DashHitbox" when the dashing player collides with the ball
    /// This method will calculate the velocity of the ball upon the player hitting it with their dash
    /// </summary>
    public void CalculateVelocity(Vector3 dirRef, float forceRef)
    {
        float accelerationForce = forceRef / accelerationTime;
        StartCoroutine(Accelerate(dirRef,accelerationForce));
    }
    /// <summary>
    /// Calculates the velocity the ball should sustain upon finishing acceleration
    /// </summary>
    private void CalculateSustainVelocity()
    {
        SetDrag(startingDrag);
        sustainVelocity = maxVelocity * sustainPercent;
    }
    /// <summary>
    /// Called in update if the ball falls below the intended sustainVelocity
    /// This method will remove drag from the ball as it reaches the sustain velocity
    /// This way the ball will stop losing velocity and stay at our intended sustained velocity
    /// </summary>
    private void MaintainVelocity()
    {
        SetDrag(0);
    }
    /// <summary>
    /// Method used to setDrag throughout this script
    /// Used in the "maintainVelocity" and the "CalculateSustainVelocity" methods
    /// </summary>

    private void SetDrag(float newDrag)
    {
        Debug.Log("Ball drag set to " + newDrag);
        rigidRef.drag = newDrag;
    }
    /// <summary>
    /// Called when the ball is hit to accelerate it to max speed
	/// It takes the direction and amount of force called "direction" and applies it 
	/// over a number of frames titled "accelerationTime"
    /// </summary>
    private IEnumerator Accelerate(Vector3 direction,float acceleration)
    {
        Debug.Log("Accelerate Coroutine called");
        for (int i = 0; i < accelerationTime; i++)
        {
            rigidRef.AddForce(direction * acceleration, ForceMode.Acceleration);
            if (ballCollided)
            {
                maxVelocity = rigidRef.velocity.magnitude;
                ballCollided = false;
                break;
            }
        }
        maxVelocity = rigidRef.velocity.magnitude;
        CalculateSustainVelocity();
        yield return null;

    }
    /// <summary>
    /// Checks if the ball collides with anything so that the accelerate coroutine can be properly exited
    /// </summary>
    private void OnCollisionEnter(Collision collision)
    {
        ballCollided = true;
    }
}
