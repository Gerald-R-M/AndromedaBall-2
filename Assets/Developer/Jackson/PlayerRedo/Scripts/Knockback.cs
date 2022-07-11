using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knockback : MonoBehaviour
{
    private CharacterController controller;

    public float minimumForce = 0.2f;
    public float resistance = 3.0f;
    public float falloffRate = 5f;
    private Vector3 impact = Vector3.zero;
    
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    
    void Update()
    {
        //Once "knockbacked" is a state we'll put this in an if statement
        //so we don't check this every frame but that ain't implemented yet
        if (impact.magnitude > minimumForce)
        {
            controller.Move(impact * Time.deltaTime);
        }

        impact = Vector3.Lerp(impact, Vector3.zero, falloffRate * Time.deltaTime);


    }

    public void AddImpact(Vector3 hitDir, float force)
    {
        hitDir.Normalize();
        impact += hitDir.normalized * force / resistance;
    }
}
