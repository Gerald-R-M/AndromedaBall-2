using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Serialization;

public class OneWayWallsController : MonoBehaviour
{
    
    [SerializeField] private GameObject side1;
    [SerializeField] private GameObject side2;
    private Collider _ballCollider;
    private Collider _wall;

    // Start is called before the first frame update
    void Start()
    {
        _wall = GetComponent<Collider>();
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
        _ballCollider = other.GetComponent<Collider>();

        if (other.CompareTag("Ball"))
        {
            Physics.IgnoreCollision(_wall, _ballCollider, true);
        }
    }

    public void EnableCollision(Collider other)
    {
        _ballCollider = other.GetComponent<Collider>();
        if (other.CompareTag("Ball"))
        {
            Physics.IgnoreCollision(_wall,_ballCollider, false);
        }
    }


}