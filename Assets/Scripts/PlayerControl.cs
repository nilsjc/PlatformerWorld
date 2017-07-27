using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	public float JumpHeight;
	public float MoveSpeed;
	private Rigidbody2D myRigidBody;
	// Use this for initialization
	void Start () {
		myRigidBody = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			myRigidBody.velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, JumpHeight);
		}
		if (Input.GetKeyDown (KeyCode.P)) 
		{
			myRigidBody.velocity = new Vector2 (MoveSpeed, GetComponent<Rigidbody2D> ().velocity.y );
		}
		if (Input.GetKeyDown (KeyCode.O)) 
		{
			myRigidBody.velocity = new Vector2 (-MoveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
		}

	}
}
