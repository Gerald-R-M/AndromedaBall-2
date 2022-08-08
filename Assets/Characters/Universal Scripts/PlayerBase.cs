using System;
using System.Collections;
using System.Collections.Generic;
using Developer.Jackson.PlayerRedo.Scripts;
using UnityEngine;

namespace Developer.Jackson.PlayerRedo.Scripts
{
    [RequireComponent(typeof(Movement))]
    [RequireComponent(typeof(InputProcessor))]
    [RequireComponent(typeof(Knockback))]

    public class PlayerBase : MonoBehaviour
    {
        public int playerIndex;
        [HideInInspector] public CharacterController controller;
        [HideInInspector] public Animator anim;
        [HideInInspector] public float speed;

        private InputProcessor playerInput;
        private Knockback knockback;

        private float xInput, yInput;
        private bool abil1, abil2, swing;
        //States: 0 = Idle, 1 = Moving, 2 = Charge, 3 = Swing, 4 = Knockback, will add more 
        private int state = 0;

        public float baseSpeed;
        public float sprintSpeed;

        public Ability ability1;
        public Ability ability2;

        [HideInInspector] public Vector3 dir;



        // Start is called before the first frame update
        void Start()
        {
            controller = this.GetComponent<CharacterController>();
            playerInput = this.GetComponent<InputProcessor>();
            anim = this.GetComponent<Animator>();
            knockback = this.GetComponent<Knockback>();
            speed = baseSpeed;
            state = 0;
        }

        // Update is called once per frame
        void Update()
        {
            if (playerIndex == 1)
            {
                xInput = playerInput.input.x;
                yInput = playerInput.input.y;
                abil1 = playerInput.p1_ability1;
                abil2 = playerInput.p1_ability2;
                swing = playerInput.p1_swing;
            }

            else if (playerIndex == 2)
            {
                xInput = playerInput.input2.x;
                yInput = playerInput.input2.y;
                abil1 = playerInput.p2_ability1;
                abil2 = playerInput.p2_ability2;
                swing = playerInput.p2_swing;
            }

            if (abil1)
            {
                ability1.Activate();
            }
            
            if (abil2)
            {
                Debug.Log("Ability 2 Acitvated");
                ability2.Activate();
            }

            
            dir = new Vector3(xInput, 0, yInput).normalized;

        }

        public void ReturnToBaseSpeed()
        {
            speed = baseSpeed;
        }
        
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Ball"))
            {
                Vector3 impactVector = collision.gameObject.GetComponent<Rigidbody>().velocity;
                Vector3 impactVectorFixed = new Vector3(impactVector.x * -1, 0, impactVector.z * -1);
                knockback.AddImpact(impactVectorFixed, impactVector.magnitude);
            }
        }

        public void SetState(int newState)
        {
            state = newState;
        }

        public int GetState()
        {
            return state;
        }
    }
}
