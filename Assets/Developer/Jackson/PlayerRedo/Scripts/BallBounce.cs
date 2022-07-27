using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    [SerializeField] private float minVelocity = 10f;
    [SerializeField] private float maxVelocity = 500f;

    private Vector3 lastFrameVelocity;
    private Rigidbody rb;
    private HitsparkController hitspark;

    private void OnEnable()
    {
        rb = GetComponent<Rigidbody>();
        hitspark = GetComponent<HitsparkController>();
    }
    
    void Update()
    {
        lastFrameVelocity = rb.velocity;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Bounce(collision.GetContact(0).normal);
    }

    private void Bounce(Vector3 collisionNormal)
    {
        var speed = lastFrameVelocity.magnitude;
        var direction = Vector3.Reflect(lastFrameVelocity.normalized, collisionNormal);
        rb.velocity = direction * Mathf.Clamp(speed, minVelocity, maxVelocity);
        hitspark.Play(collisionNormal);
    }
}
