using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate ()
	{
		while(Input.GetKeyDown("left"))
		{
			gameObject.transform.Translate(-speed, 0, 0);
		}
		while(Input.GetKeyDown("right"))
		{
			gameObject.transform.Translate(speed, 0, 0);
		}
		while(Input.GetKeyDown("up"))
		{
			gameObject.transform.Translate(0, 0, speed);
		}
		while(Input.GetKeyDown("down"))
		{
			gameObject.transform.Translate(0, 0, -speed);
		}
		
	}
}
