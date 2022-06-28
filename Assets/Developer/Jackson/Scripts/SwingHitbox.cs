using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Developer.Jackson.PlayerRedo.Scripts
{
    public class SwingHitbox : MonoBehaviour
    {
        private BoxCollider collider;
        private BasicSwing swingData;

        private float velRef;

        // Start is called before the first frame update
        void Start()
        {
            collider = GetComponent<BoxCollider>();
            swingData = collider.transform.root.GetComponent<BasicSwing>();
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

                Vector3 newDirection = (transform.root.GetComponent<PlayerBase>().dir) * (swingData.force);
                Vector3 currentVelocity = other.gameObject.GetComponent<Rigidbody>().velocity;

                other.GetComponent<Rigidbody>().AddForce(newDirection, ForceMode.VelocityChange);
            }
        }
    }
}