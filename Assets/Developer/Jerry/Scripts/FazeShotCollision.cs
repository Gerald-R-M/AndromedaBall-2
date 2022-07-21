using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FazeShotCollision : MonoBehaviour
{
	private GameObject _ballRef;
	private Vector3 _ballVel;
	private bool _wasBallHit = false;
	private FazeShot _abilityRef;
	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Ball"))
		{
			other.transform.parent = transform; // Set the ball as a child of the hitbox so it will rotate with the player
			_ballRef = other.gameObject; //store a reference to the ball to later be unparented
			_ballVel = _ballRef.gameObject.GetComponent<Rigidbody>().velocity; //store the balls velocity at the time of collision
			_ballRef.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero; //Remove all velocity from the ball
			_abilityRef.FazeShotTriggered();//Tell the ability script to start tracking the time that the ball is allowed to be grabbed by reverb
		}
	}
	private void Start()
	{
		_abilityRef = GetComponentInParent<FazeShot>();
	}
	private void Update()
	{
		if (_ballRef.gameObject.GetComponent<Rigidbody>().velocity != Vector3.zero)
		{
			_wasBallHit = true;
			_abilityRef.EndFazeShot();
		}
	}
	public void UnfazeBall()
	{
		if (_ballRef != null && _ballRef.transform.parent != null)
		{
			_ballRef.transform.parent = null;
			if (!_wasBallHit)
			{
				_ballRef.gameObject.GetComponent<Rigidbody>().velocity = _ballVel;

			}
			else
			{
				_ballRef.gameObject.GetComponent<Rigidbody>().velocity *= _abilityRef.GetMultiplier();

			}
			_ballRef = null;
			_wasBallHit = false;
			_ballVel = Vector3.zero;
		}
	}
}
