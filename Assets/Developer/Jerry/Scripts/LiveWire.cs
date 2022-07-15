using System.Collections;
using System.Collections.Generic;
using Developer.Jackson.PlayerRedo.Scripts;
using UnityEngine;

public class LiveWire : Ability
{
    //Inspector Variables
    [SerializeField]private GameObject mine;

    
    //Private Variables
    private LiveWireMine _mineRef;
    private bool isMineActive = false;
    public override void Activate()
    {
        ActivateLiveWire();
    }

    private void ActivateLiveWire()
    {
        if (!isMineActive)
        {
            isMineActive = true;
            Instantiate(mine, gameObject.transform.position, gameObject.transform.rotation);
        }
    }
}
