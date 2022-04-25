using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    [SerializeField] public sfxManager sfxRef;
    [SerializeField] public AudioClip clickSound;
    [SerializeField] public AudioClip backSound;

    public void ButtonPlay(){
        sfxRef.playSFX(clickSound);
        SceneManager.LoadScene("GameSceneFinal");
    }
    public void ButtonMainMenu(){
        sfxRef.playSFX(backSound);
        SceneManager.LoadScene("MainMenu");
    }
    public void ButtonControls(){
        sfxRef.playSFX(clickSound);
        SceneManager.LoadScene("ControlsMenu");
    }
    public void ButtonCredits(){
        sfxRef.playSFX(clickSound);
        SceneManager.LoadScene("CreditsMenu");
    }
    public void ButtonQuit(){
        sfxRef.playSFX(clickSound);
        Application.Quit();
    }
}
