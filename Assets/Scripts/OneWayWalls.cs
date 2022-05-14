using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class OneWayWalls : MonoBehaviour
{
    
    [SerializeField] private Collider Side1;
    [SerializeField] private Collider Side2;
    private Collider ballCollider;
    private Collider wall;

    // Start is called before the first frame update
    void Start()
    {
        wall = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        ballCollider = other.GetComponent<Collider>();
        if (other.CompareTag("Ball"))
        {
            Physics.IgnoreCollision(wall,ballCollider, true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        ballCollider = other.GetComponent<Collider>();
        if (other.CompareTag("Ball"))
        {
            Physics.IgnoreCollision(wall, ballCollider, false);
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