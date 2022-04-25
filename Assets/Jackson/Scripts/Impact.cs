using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impact : MonoBehaviour
{
    private CharacterController controller;

    public float minimumForce = 0.2f;
    public float resistance = 3.0f;
    public float falloffRate = 5f;
    private Vector3 impact = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
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
