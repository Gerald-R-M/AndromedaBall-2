using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballReset : MonoBehaviour
{
    private Vector3 respawnPOS;

    // Start is called before the first frame update
    void Start()
    {
        respawnPOS = transform.position;
    }

    public void resetPos()
    {
        transform.position = respawnPOS;
        this.GetComponent<Rigidbody>().velocity = Vector3.zero;
        this.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }
}
