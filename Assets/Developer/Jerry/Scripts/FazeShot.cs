using System.Collections;
using System.Collections.Generic;
using Developer.Jackson.PlayerRedo.Scripts;
using UnityEngine;

public class FazeShot : Ability
{
    // Start is called before the first frame update
    public override void Activate()
    {
        ActivateLiveWire();
    }

    // Update is called once per frame
    private void ActivateLiveWire()
    {
        Debug.Log("Live Wire Activated!");
    }
}
