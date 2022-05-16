using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FighterSelect : MonoBehaviour
{
    private SelectionStorage storageRef;
    [SerializeField] private Text oneText;
    [SerializeField] private Text twoText;
    [SerializeField] private GameObject fighter;
    private Boolean playerOneSelect = true;
    private Boolean playerTwoSelect = false;
    private string fighterTag;
    private void Start()
    {
        storageRef = FindObjectOfType<SelectionStorage>();
        fighterTag = "Player 1";
    }

    public void PlayerOneSetSelect()
    {
        playerOneSelect = true;
        playerTwoSelect = false;
        oneText.gameObject.SetActive(true);
        twoText.gameObject.SetActive(false);
        fighterTag = "Player 1";
    }
    public void PlayerTwoSetSelect()
    {
        playerOneSelect = false;
        playerTwoSelect = true;
        oneText.gameObject.SetActive(false);
        twoText.gameObject.SetActive(true);
        fighterTag = "Player 2";
    }
    public void SetFighter()
    {
        if (playerOneSelect)
        {
            storageRef.StorePlayerOne(fighter, fighterTag);
        }
        else if (playerTwoSelect)
        {
            storageRef.StorePlayerTwo(fighter, fighterTag);
        }
    }
}
