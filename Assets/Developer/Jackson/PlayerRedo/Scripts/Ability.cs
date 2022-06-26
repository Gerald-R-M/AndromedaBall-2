using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

//[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Ability", order = 1)]
public class Ability : MonoBehaviour
{
    public string name;
    public Sprite icon;

    private CharacterController characterController;
    private PlayerBase playerBase;
    private InputProcessor inputProcessor;

    void Start()
    {
        characterController = this.GetComponent<CharacterController>();
        playerBase = this.GetComponent<PlayerBase>();
        inputProcessor = this.GetComponent<InputProcessor>();
    }
}
