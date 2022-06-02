using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private CharacterController controller;
    private InputProcessor playerInput;
    private Impact impactController;
    private Player playerRef;

    private float speed;
    //0 = regular movement, 1 = slowed (for attacks)
    private int movementState;

    public float baseSpeed = 5f;
    public float attackMoveSpeed = 1f;
    public AudioClip dashSound;

    private Animator anim;



    private sfxManager sfxRef;
    public AudioClip hitSound;
    public Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        playerInput = GetComponent<InputProcessor>();
        anim = GetComponent<Animator>();
        impactController = GetComponent<Impact>();
        movementState = 0;
        speed = baseSpeed;
        sfxRef = FindObjectOfType<sfxManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void ChangeMovementState(int index)
    {
        movementState = index;
    }
    
    public void SlowDown()
    {
        movementState = 1;
    }

    public void SpeedBackUp()
    {
        movementState = 0;
    }
    
    public void ReturnToBaseSpeed()
    {
        speed = baseSpeed;
    }


    public void Move(Vector3 dir)
    {
        //this if statement is for possible analog control dead zone
        if (dir.magnitude >= 0.05f)
        {
            if (movementState == 0)
            {
                speed = baseSpeed;
            }

            if (movementState == 1)
            {
                speed = attackMoveSpeed;
            }

            controller.Move(dir.normalized * speed * Time.deltaTime);
            Vector3 dirRotation = dir.normalized;
            float targetAngle = Mathf.Atan2(dirRotation.x, dir.z) * Mathf.Rad2Deg;

            controller.transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);
        }


        anim.SetFloat("velocity", controller.velocity.magnitude);
    }
}
