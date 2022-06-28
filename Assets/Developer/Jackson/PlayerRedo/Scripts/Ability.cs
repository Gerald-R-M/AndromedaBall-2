using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Developer.Jackson.PlayerRedo.Scripts
{
    public class Ability : MonoBehaviour
    {
        public String name;
        public Sprite icon;
        protected CharacterController characterController;
        protected PlayerBase playerBase;
        protected InputProcessor inputProcessor;
        protected Movement movement;

        void Start()
        {
            characterController = this.GetComponent<CharacterController>();
            playerBase = this.GetComponent<PlayerBase>();
            inputProcessor = this.GetComponent<InputProcessor>();
            movement = this.GetComponent<Movement>();
        }

        public virtual void Activate()
        {

        }
    }
}