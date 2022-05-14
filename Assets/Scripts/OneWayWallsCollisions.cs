using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneWayWallsCollisions : MonoBehaviour
{
    private OneWayWallsController _contRef;
    // Start is called before the first frame update
    void Start()
    {
        _contRef = GetComponentInParent<OneWayWallsController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        _contRef.DisableCollision(other);
    }
    private void OnTriggerExit(Collider other)
    {
        _contRef.EnableCollision(other);
    }
}
