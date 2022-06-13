using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    private sfxManager _sfxRef;
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
        _sfxRef = FindObjectOfType<sfxManager>();
        storageRef = FindObjectOfType<SelectionStorage>();
    }

    public void ButtonPlay()
    {
        Debug.Log("Beginning to play game");
        _sfxRef.PlaySfx(clickSound);
        arena = storageRef.LoadArena();
        SceneManager.LoadScene(arena);
    }
    public void ButtonFighter()
    {
        _sfxRef.PlaySfx(clickSound);
        SceneManager.LoadScene("FighterScene");
    }    public void ButtonArena()
    {
        _sfxRef.PlaySfx(clickSound);
        SceneManager.LoadScene("ArenaScene");
    }
    public void ButtonMainMenu(){
        _sfxRef.PlaySfx(backSound);
        SceneManager.LoadScene("MainMenu");
    }
    public void ButtonControls(){
        _sfxRef.PlaySfx(clickSound);
        SceneManager.LoadScene("ControlsMenu");
    }
    public void ButtonCredits(){
        _sfxRef.PlaySfx(clickSound);
        SceneManager.LoadScene("CreditsMenu");
    }
    public void ButtonQuit(){
        _sfxRef.PlaySfx(clickSound);
        Application.Quit();
    }
}
