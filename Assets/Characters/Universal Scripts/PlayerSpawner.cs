using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{

	public void SpawnPlayer(GameObject fighter, string fighterTag)
	{
		fighter.tag = fighterTag;
		Debug.Log("spawning " + fighter + " with the tag " + fighter.tag);
		Instantiate(fighter,this.transform.position, this.transform.rotation);
	}
}
