using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControl : MonoBehaviour {
	public Camera cam;
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) 
		{
			RaycastHit2D hit = Physics2D.Raycast(cam.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
			if (hit.collider != null) {
				Debug.Log (hit.collider.name);
				GameObject killedSanta = GameObject.Find (hit.collider.name).gameObject;
				killedSanta.SetActive (false);
			}
		}
	}
}
