using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionStorage : MonoBehaviour
{
    private string sceneToLoad;
    private static SelectionStorage _Instance;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (_Instance != null && _Instance != this)
            Destroy(gameObject);
        else
            _Instance = this;
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
    //TODO character select logic

    public void Destroy()
    {
        Destroy(gameObject);
    }
}
