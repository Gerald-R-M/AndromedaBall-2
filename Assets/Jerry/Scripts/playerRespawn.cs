using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playerRespawn : MonoBehaviour
{
    private Vector3 respawnPos;
    private CharacterController cc;
    [SerializeField] private Text player1Score;
    [SerializeField] private Text player2Score;
    [SerializeField] private GameTimer timerRef;

    [HideInInspector] public int oneScore = 0;
    [HideInInspector] public int twoScore = 0;

    [SerializeField] public AudioClip deathSound;
    [SerializeField] public AudioClip pointSound;
    [SerializeField] public sfxManager sfxRef;


    public ballReset ballRef;
    void Start()
    {
        respawnPos = transform.position;
        cc = GetComponent<CharacterController>();
        Debug.Log("Player should respawn at: " + respawnPos);
    }
    private void Update()
    {

    }
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player death script has entered a trigger");
        if(other.gameObject.CompareTag("Death"))
        {
            Debug.Log("Player died");

            cc.enabled = false;
            transform.position = new Vector3 (respawnPos.x, respawnPos.y, respawnPos.z);
            cc.enabled = true;
            sfxRef.playSFX(deathSound);
            ballRef.resetPos();
            if (gameObject.CompareTag("Player 1"))
            {
                twoScore++;
                player2Score.text = twoScore.ToString();
            }
            else if (gameObject.CompareTag("Player 2"))
            {
                oneScore++;
                player1Score.text = oneScore.ToString();
            }
            timerRef.updateScores();
        }
    }
}
