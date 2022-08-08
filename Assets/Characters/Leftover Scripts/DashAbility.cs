using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashAbility : MonoBehaviour
{
    private CharacterController controller;
    private InputProcessor playerInput;
    private Player playerRef;
    private PlayerMovement playerMovement;


    [SerializeField]
    private float dashSpeed = 15f;
    [SerializeField]
    private float dashTime;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        playerInput = GetComponent<InputProcessor>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator Dash(Vector3 dirRef)
    {
        Debug.Log("Dash!!!!");
        float startTime = Time.time;
        Vector3 dir = new Vector3(dirRef.x, 0, dirRef.y).normalized;

        while (Time.time < startTime + dashTime)
        {
            controller.Move(dir.normalized * dashSpeed * Time.deltaTime);
            yield return null;
        }
        playerMovement.ReturnToBaseSpeed();
    }
}
