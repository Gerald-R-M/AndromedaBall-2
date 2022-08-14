using System.Collections;
using System.Collections.Generic;
using Developer.Jackson.PlayerRedo.Scripts;
using UnityEngine;

public class DashHitbox : MonoBehaviour
{
    private BoxCollider collider;

    private Dash dashData;

    private float velRef;
    
    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<BoxCollider>();
        dashData = collider.transform.root.GetComponent<Dash>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            velRef = other.GetComponent<Rigidbody>().velocity.magnitude;

            Vector3 newDirection = (transform.root.GetComponent<PlayerBase>().dir) * (dashData.force);
            Vector3 currentVelocity = other.gameObject.GetComponent<Rigidbody>().velocity;

            other.GetComponent<Rigidbody>().AddForce(newDirection, ForceMode.VelocityChange);
        }
    }
}
