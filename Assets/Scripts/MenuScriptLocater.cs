using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScriptLocater : MonoBehaviour
{   
    private MenuScript _menuRef;
    // Start is called before the first frame update
    private void Start()
    {
        _menuRef = FindObjectOfType<MenuScript>();
    }

    public void ButtonPlay()
    {
        _menuRef.ButtonPlay();
    }
    public void ButtonFighter()
    {
        _menuRef.ButtonFighter();
    }
    public void ButtonArena()
    {
        _menuRef.ButtonArena();
    }
    public void ButtonMainMenu()
    {
        _menuRef.ButtonMainMenu();
    }
    public void ButtonControls()
    {
        _menuRef.ButtonControls();
    }
    public void ButtonCredits()
    {
        _menuRef.ButtonCredits();
    }
    public void ButtonQuit()
    {
        _menuRef.ButtonQuit();
    }
}
