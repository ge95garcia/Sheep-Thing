using UnityEngine;
using System.Collections;

public class SheepBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	/*void Update () {
		if (Input.GetMouseButtonDown(0))
            Debug.Log("Pressed left click.");
		if ( Input.GetMouseButtonDown(0)){
			var hit : RaycastHit;
			var ray : Ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			var select = GameObject.FindWithTag("select").transform;
			if (Physics.Raycast (ray, hit, 100.0)){
				Debug.Log("THE SHEEP HAS BEEN SHEEPED");
			}
		}
		
	}*/

	void OnMouseDown ()
	{
		Debug.Log("THE SHEEP HAS BEEN SHEEPED");
	}

}
