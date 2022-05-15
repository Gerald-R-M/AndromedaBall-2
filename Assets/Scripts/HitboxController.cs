using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HitboxController : MonoBehaviour
{
    private BoxCollider hitboxCollider;
    [SerializeField]
    private float force = 5f;

    private float min = 0f;
    
    private float velRef;

    // Start is called before the first frame update
    void Start()
    {
        hitboxCollider = GetComponent<BoxCollider>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            /*
            if (other.GetComponent<Rigidbody>().velocity.magnitude < 2f)
            {
                other.GetComponent<Rigidbody>().AddForce(new Vector3(500, 0, 0));
            }
            */

            velRef = other.GetComponent<Rigidbody>().velocity.magnitude;

            Vector3 newDirection = (other.transform.position - transform.position)*(force/50);
            Vector3 currentVelocity = other.gameObject.GetComponent<Rigidbody>().velocity;
            
            
            //other.GetComponent<Rigidbody>().velocity = Vector3.zero;
            //other.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            other.GetComponent<Rigidbody>().
                AddForce(newDirection, ForceMode.Impulse);
        }
    }
}