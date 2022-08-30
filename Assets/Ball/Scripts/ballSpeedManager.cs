using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballSpeedManager : MonoBehaviour
{
    public Vector3 currentVelocity; //TODO change this to private after testing is complete
    private Rigidbody rigidRef;
    [SerializeField] private float accelerationTime = 10f; //How many frames should the ball accelerate before reaching max velocity
    // Start is called before the first frame update
    void Start()
    {
        rigidRef = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        currentVelocity = rigidRef.velocity;
        
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
    private void CalculateSustainSpeed()
    {
        
    }
    /// <summary>
    /// Called when the ball is hit to accelerate it to max speed
	/// It takes the direction and amount of force called "direction" and applies it 
	/// over a number of frames titled "acclerationTime"
    /// </summary>
    private IEnumerator Accelerate(Vector3 direction,float acceleration)
    {
        Debug.Log("Accelerate Coroutine called");
        for (int i = 0; i < accelerationTime; i++)
        {
            rigidRef.AddForce(direction * acceleration, ForceMode.Acceleration);
            yield return null;
        }
    }
}
