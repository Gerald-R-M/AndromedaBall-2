using System.Collections;
using System.Collections.Generic;
using Developer.Jackson.PlayerRedo.Scripts;
using UnityEngine;

public class LiveWire : Ability
{
    //Inspector Variables
    [SerializeField]private GameObject mine;
    [SerializeField] private float armTime = 0.5f;
    
    //Private Variables
    private LiveWireMine _mineRef;
    private bool isMineActive = false;
    public override void Activate()
    {
        ActivateLiveWire();
    }

    private void ActivateLiveWire()
    {
        Debug.Log("Live Wire Activated!");
        if (!isMineActive)
        {
            Debug.Log("Mine Placed!");

            isMineActive = true;
            GameObject placedMine = Instantiate(mine, gameObject.transform.position, gameObject.transform.rotation) as GameObject;
            _mineRef = placedMine.GetComponent<LiveWireMine>();
        }
        else
        {
            _mineRef.ExplodeMine();
            isMineActive = false;

        }
    }
}
