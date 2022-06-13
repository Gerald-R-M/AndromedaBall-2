using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    [SerializeField] public sfxManager sfxRef;
    [SerializeField] private AudioClip clickSound;
    [SerializeField] private AudioClip backSound;
    private SelectionStorage storageRef;
    private static MenuScript _Instance;

    private string arena;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (_Instance != null && _Instance != this)
            Destroy(gameObject);
        else
            _Instance = this;

    }
    private void Start()
    {
        storageRef = FindObjectOfType<SelectionStorage>();
    }

    public void ButtonPlay()
    {
        Debug.Log("Beginning to play game");
        sfxRef.PlaySfx(clickSound);
        arena = storageRef.LoadArena();
        SceneManager.LoadScene(arena);
    }
    public void ButtonFighter()
    {
        sfxRef.PlaySfx(clickSound);
        SceneManager.LoadScene("FighterScene");
    }    public void ButtonArena()
    {
        sfxRef.PlaySfx(clickSound);
        SceneManager.LoadScene("ArenaScene");
    }
    public void ButtonMainMenu(){
        sfxRef.PlaySfx(backSound);
        SceneManager.LoadScene("MainMenu");
    }
    public void ButtonControls(){
        sfxRef.PlaySfx(clickSound);
        SceneManager.LoadScene("ControlsMenu");
    }
    public void ButtonCredits(){
        sfxRef.PlaySfx(clickSound);
        SceneManager.LoadScene("CreditsMenu");
    }
    public void ButtonQuit(){
        sfxRef.PlaySfx(clickSound);
        Application.Quit();
    }
}
