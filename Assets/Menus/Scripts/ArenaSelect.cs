using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArenaSelect : MonoBehaviour
{
    private SelectionStorage storageRef;
    [SerializeField] private string sceneName;

    private void Start()
    {
        storageRef = FindObjectOfType<SelectionStorage>();
    }

    public void SetScene()
    {
        storageRef.StoreArena(sceneName);
    }
    
}
