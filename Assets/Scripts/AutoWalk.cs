using UnityEngine;
using System.Collections;

public class AutoWalk : MonoBehaviour {

	bool moveUp = false;
	float speed;
	public Transform target;
	Vector3 endPoint;
	Vector3 startPoint;
	float randomX;
	// Use this for initialization
	void Start (){
		speed = Random.Range (0.01f, 0.2f);
		endPoint = new Vector3(0.0f, 0.0f, 0.0f);
		startPoint = new Vector3();
		randomX = Random.Range (-3.0f, 3.0f);
		startPoint = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (!moveUp) {
			transform.position = Vector3.MoveTowards (transform.position, endPoint, speed);
		} else {
			transform.position = Vector3.MoveTowards (transform.position, startPoint, speed);
		}
		if (transform.position.y <= 0.1f) {
			moveUp = true;
		}
		if(transform.position.y >= startPoint.y){
			moveUp = false;
		}
	}
}