using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private CharacterController controller;
    private InputProcessor playerInput;
    private Impact impactController;

    private float speed;
    //0 = regular movement, 1 = slowed (for attacks)
    private int movementState;

    public float baseSpeed = 5f;
    public float dashSpeed = 15f;
    public float attackMoveSpeed = 1f;
    public float dashTime;
    public AudioClip dashSound;

    private Animator anim;

    private float xInput, yInput;
    private bool dash, swing;

    [SerializeField] private sfxManager sfxRef;
    public AudioClip hitSound;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        playerInput = GetComponent<InputProcessor>();
        anim = GetComponent<Animator>();
        impactController = GetComponent<Impact>();
        movementState = 0;
        speed = baseSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.tag == "Player 1")
        {
            xInput = playerInput.input.x;
            yInput = playerInput.input.y;
            dash = playerInput.dash;
            swing = playerInput.swing1;
        }

        else if (this.tag == "Player 2")
        {
            xInput = playerInput.input2.x;
            yInput = playerInput.input2.y;
            dash = playerInput.dash2;
            swing = playerInput.swing2;
        }
        //convert WASD input into a direction vector
        
        Vector3 dir = new Vector3(xInput, 0, yInput).normalized;

        if (dash)
        {
            Debug.Log("Dash!");
            sfxRef.playSFX(dashSound);
            StartCoroutine(Dash());
        }
        
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
                Vector3 dirRotation =  dir.normalized;
            float targetAngle = Mathf.Atan2(dirRotation.x, dir.z) * Mathf.Rad2Deg;
            
            controller.transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);
            }

        
        if (swing)
        {
            Debug.Log("swing!");
        }
        

         anim.SetFloat("velocity", controller.velocity.magnitude);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            sfxRef.playSFX(hitSound);
            Vector3 impactVector = collision.gameObject.GetComponent<Rigidbody>().velocity;
            Vector3 impactVectorFixed = new Vector3(impactVector.x * -1, 0, impactVector.z * -1);
            impactController.AddImpact(impactVectorFixed, impactVector.magnitude);
        }
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

    IEnumerator Dash()
    {
        Debug.Log("Dash!!!!");
        float startTime = Time.time;
        Vector3 dir = new Vector3(xInput, 0, yInput).normalized;

        while (Time.time < startTime + dashTime)
        {
            controller.Move(dir.normalized * dashSpeed * Time.deltaTime);
            yield return null;
        }
        speed = baseSpeed;
    }
}
