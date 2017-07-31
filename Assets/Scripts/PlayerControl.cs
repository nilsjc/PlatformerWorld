using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	public float jumpHeight;
	public float moveSpeed;
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;

	private Rigidbody2D myRigidBody;
	private bool Grounded;

	// Use this for initialization
	void Start () {
		myRigidBody = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate(){
		Grounded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatIsGround);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space) && Grounded) 
		{
			myRigidBody.velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, jumpHeight);
		}
		if (Input.GetKey (KeyCode.P)) 
		{
			myRigidBody.velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D> ().velocity.y );
		}
		if (Input.GetKey (KeyCode.O)) 
		{
			myRigidBody.velocity = new Vector2 (-moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
		}

	}
}
