﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {
	private Vector3 velocity;

	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("up") || Input.GetKey ("w")) {
			transform.position += new Vector3 (0, 0, speed);
		}
		if (Input.GetKey ("down") || Input.GetKey ("s")) {
			transform.position -= new Vector3 (0, 0, speed);
		}
		if (Input.GetKey ("right") || Input.GetKey ("d")) {
			transform.position += new Vector3 (speed, 0, 0);
		}
		if (Input.GetKey ("left") || Input.GetKey ("a")) {
			transform.position -= new Vector3 (speed, 0, 0);
		}
		//transform.Rotate(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0);
	}

	/*void FixedUpdate ()
	{
		if(Input.GetKeyDown("left"))
		{
			gameObject.transform.Translate(-speed, 0, 0);
		}
		if(Input.GetKeyDown("right"))
		{
			gameObject.transform.Translate(speed, 0, 0);
		}
		if(Input.GetKeyDown("up"))
		{
			gameObject.transform.Translate(0, 0, speed);
		}
		if(Input.GetKeyDown("down"))
		{
			gameObject.transform.Translate(0, 0, -speed);
		}
		
	}*/
}
