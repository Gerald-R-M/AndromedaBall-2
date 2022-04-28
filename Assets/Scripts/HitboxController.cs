using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HitboxController : MonoBehaviour
{
    private BoxCollider hitboxCollider;
    [SerializeField]
    private float force = 50;
    
    private float velRef;

    // Start is called before the first frame update
    void Start()
    {
        hitboxCollider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            if (other.GetComponent<Rigidbody>().velocity.magnitude < 2f)
            {
                other.GetComponent<Rigidbody>().AddForce(new Vector3(500, 0, 0));
            }

            velRef = other.GetComponent<Rigidbody>().velocity.magnitude;
            other.GetComponent<Rigidbody>()
                .AddForce(((other.transform.position - transform.position) * (force + velRef)));
        }
    }
}