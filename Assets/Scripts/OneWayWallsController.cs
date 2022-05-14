using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class OneWayWallsController : MonoBehaviour
{
    
    [SerializeField] private Collider Side1;
    [SerializeField] private Collider Side2;
    private Collider _ballCollider;
    private Collider _wall;

    // Start is called before the first frame update
    void Start()
    {
        _wall = GetComponent<Collider>();
    }
    private void Update()
    {
        Debug.Log("Are wall and ball collisions being ignored? : " +
                  Physics.GetIgnoreCollision(_wall, _ballCollider));
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Entered normally in onewaywalls");

    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger Exited in onewaywalls");

    }

    public void DisableCollision(Collider other)
    {
        Debug.Log("Trigger Entered DisableCollision called");
        _ballCollider = other.GetComponent<Collider>();

        if (other.CompareTag("Ball"))
        {
            Debug.Log("Ball Detected in disableCollision call");
            Physics.IgnoreCollision(_wall, _ballCollider, true);


        }
    }

    public void EnableCollision(Collider other)
    {
        Debug.Log("Trigger exited EnableCollision called");
        _ballCollider = other.GetComponent<Collider>();
        if (other.CompareTag("Ball"))
        {
            Physics.IgnoreCollision(_wall,_ballCollider, false);
            if (Side1.enabled)
            {
                Side1.enabled = false;
                Side2.enabled = true;
            }
            else if (Side2.enabled)
            {
                Side1.enabled = true;
                Side2.enabled = false;
            }
        }
    }


}