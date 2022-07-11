using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour
{
    [SerializeField] public playerRespawn scoreRef;
    [SerializeField] public Text winText;
    [SerializeField] public Text continueText;
    [SerializeField] 
    private float timer = 120f;
    private int oneScore;
    private int twoScore;
    private bool gameOver;
    private InputProcessor playerInput;


    void Start()
    {
        oneScore = scoreRef.oneScore;
        twoScore = scoreRef.twoScore;
        playerInput = GetComponentInParent<InputProcessor>();

    }

    // Update is called once per frame
    void Update()
    {
        if(!gameOver)
        {
            if (timer > 0)
            {
                int min = Mathf.FloorToInt(timer / 60);
                int sec = Mathf.FloorToInt(timer % 60);
                gameObject.GetComponent<Text>().text = min.ToString("00") + ":" + sec.ToString("00");
                timer -= Time.deltaTime;
            }
            else if (timer <= 0)
            {
                endGame();
            }
        }
        else
        {
            if(playerInput.p1_swing ||playerInput.p2_swing)
            {
                Debug.Log("Loading main menu...");
                SceneManager.LoadScene("MainMenu");
            }
            else if(playerInput.p1_ability1)
            {
                Debug.Log("Quitting game....");

                Application.Quit();
            }
        }


    }
    public void updateScores()
    {
        oneScore = scoreRef.oneScore;
        twoScore = scoreRef.twoScore;
    }
    void endGame()
    {
        gameOver = true;
        winText.gameObject.SetActive(true);
        continueText.gameObject.SetActive(true);
        if (oneScore > twoScore)
        {

            winText.text = "Player 1 Wins!";
           // continueText.text = "Press the 'Swing' key to go back to the main menu. \n Press the 'Dash' key to quit!";
        }
        else if(twoScore > oneScore)
        {
            winText.text = "Player 2 Wins!";
            //continueText.text = "Press the 'Swing' key to go back to the main menu. \n Press the 'Dash' key to quit!";
        }
        else
        {
            winText.text = "Looks like a draw!";
           // continueText.text = "Press the 'Swing' key to go back to the main menu. \n Press the 'Dash' key to quit!";
        }
    }
}
