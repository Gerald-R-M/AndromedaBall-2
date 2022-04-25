using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batImpact : MonoBehaviour
{
    // Start is called before the first frame update
    private InputProcessor playerInput;
    [SerializeField] private float force = 50;
    private float velRef;
    [SerializeField] public sfxManager sfxRef;
    [SerializeField] public AudioClip swingSound;

    void Start()
    {
        playerInput = GetComponentInParent<InputProcessor>();
    }

    private void OnTriggerStay(Collider other)
    {
        //Debug.Log("Bat Triggered is in Something");
        if (other.gameObject.CompareTag("Ball"))
        {
            //Debug.Log("Ball and Bat without swing");
            if (playerInput.swing1 || playerInput.swing2)
            {
                if(other.GetComponent<Rigidbody>().velocity.magnitude < 2f)
                {
                    other.GetComponent<Rigidbody>().AddForce(new Vector3(500, 0, 0));
                }
                //Debug.Log("Ball and Bat with swing");
                Debug.Log("ball");
                velRef = other.GetComponent<Rigidbody>().velocity.magnitude;
                other.GetComponent<Rigidbody>().AddForce(((other.transform.position - transform.position) * (force + velRef))) ; //add double double current force in the opposite direction?

            }

        }


    }
}
