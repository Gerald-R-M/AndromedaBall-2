using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallBall : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Wall"))
        {
            wallBounce();
        }
    }
    void wallBounce()
    {
        Debug.Log("Ball wall bounce");

    }
}
