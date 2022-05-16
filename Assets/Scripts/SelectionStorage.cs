using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectionStorage : MonoBehaviour
{
    private string sceneToLoad;
    private static SelectionStorage _Instance;
    private static GameObject playerOneFighter;
    private static string playerOneTag;
    private static GameObject playerTwoFighter;
    private static string playerTwoTag;
    private PlayerSpawner playerOneSpawnRef;
    private PlayerSpawner playerTwoSpawnRef;
    [SerializeField] private GameObject defaultFighter;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (_Instance != null && _Instance != this)
            Destroy(gameObject);
        else
            _Instance = this;

        if (playerOneFighter == null)
        {
            StorePlayerOne(defaultFighter, "Player 1");
        }

        if (playerTwoFighter == null)
        {
            StorePlayerTwo(defaultFighter, "Player 2");
        }
    }
    private void Update()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == sceneToLoad)
        {
            playerOneSpawnRef = GameObject.FindWithTag("Player 1 Spawner").GetComponent<PlayerSpawner>();
            playerTwoSpawnRef = GameObject.FindWithTag("Player 2 Spawner").GetComponent<PlayerSpawner>();
            
            playerOneSpawnRef.SpawnPlayer(playerOneFighter, playerOneTag);
            playerTwoSpawnRef.SpawnPlayer(playerTwoFighter, playerTwoTag);
            Destroy();
        }
    }
    public void StoreArena(string sceneName)
    {
        sceneToLoad = sceneName;
        Debug.Log("Scene that will be loaded: "+sceneToLoad);
    }

    public string LoadArena()
    {
        return sceneToLoad;
    }
    public void StorePlayerOne(GameObject playerOne, string playerTag)
    {
        playerOneFighter = playerOne;
        playerOneTag = playerTag;
        Debug.Log("Player One has selected: "+ playerOneFighter.name + " and their tag is set to " + playerOneTag);
    }
    
    public void StorePlayerTwo(GameObject playerTwo, string playerTag)
    {
        playerTwoFighter = playerTwo;
        playerTwoTag = playerTag;

        Debug.Log("Player Two has selected: "+ playerTwoFighter.name+" and their tag is set to " + playerTwoTag);
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }
}
