using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballLock : MonoBehaviour
{
    // Start is called before the first frame update
    private float yref;

    void Start()
    {
        yref = transform.position.y;

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > yref)
        {
            transform.position = new Vector3(transform.position.x, yref, transform.position.z);
        }
    }
}
