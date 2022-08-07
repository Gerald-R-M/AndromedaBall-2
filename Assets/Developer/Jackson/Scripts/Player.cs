
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController controller;
    private InputProcessor playerInput;
    private PlayerMovement playerMovement;
    private DashAbility dashAbility;

    [HideInInspector]
    public float xInput, yInput;
    //[HideInInspector]
    public bool ability1, ability2, swing;

    [SerializeField]
    private int playerIndex;

    [HideInInspector]
    public Vector3 dir;
    
    
    // Start is called before the first frame update
    void Start()
    {
        if (playerIndex == 1)
        {
            
        }

        controller = GetComponent<CharacterController>();
        playerInput = GetComponent<InputProcessor>();
        playerMovement = GetComponent<PlayerMovement>();
        dashAbility = GetComponent<DashAbility>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIndex == 1)
        {
            xInput = playerInput.input.x;
            yInput = playerInput.input.y;
            ability1 = playerInput.p1_ability1;
            swing = playerInput.p1_swing;
        }

        else if (playerIndex == 2)
        {
            xInput = playerInput.input2.x;
            yInput = playerInput.input2.y;
            ability1 = playerInput.p2_ability1;
            swing = playerInput.p2_swing;
        }
        
        dir = new Vector3(xInput, 0, yInput).normalized;

        if (ability1)
        {
            StartCoroutine(dashAbility.Dash(dir));
        }
        playerMovement.Move(dir);
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            //sfxRef.playSFX(hitSound);
            Vector3 impactVector = collision.gameObject.GetComponent<Rigidbody>().velocity;
            Vector3 impactVectorFixed = new Vector3(impactVector.x * -1, 0, impactVector.z * -1);
            //impactController.AddImpact(impactVectorFixed, impactVector.magnitude);
        }
    }
}
