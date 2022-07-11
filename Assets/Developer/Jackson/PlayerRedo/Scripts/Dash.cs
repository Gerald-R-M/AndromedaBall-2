using System.Collections;
using System.Collections.Generic;
using Developer.Jackson.PlayerRedo.Scripts;
using UnityEngine;

public class Dash : Ability
{
    public float dashSpeed = 15f;
    public float dashTime = 0.1f;

    public override void Activate()
    {
        StartCoroutine(DashFunction());
    }

    public IEnumerator DashFunction()
    {
        float startTime = Time.time;
        Vector3 dashDir = new Vector3(playerBase.dir.x, 0, playerBase.dir.z).normalized;
        Debug.Log("dashDir: " + dashDir.ToString());

        while (Time.time < startTime + dashTime)
        {
            characterController.Move(dashDir.normalized * dashSpeed * Time.deltaTime);
            yield return null;
        }
        playerBase.ReturnToBaseSpeed();
    }
}
 