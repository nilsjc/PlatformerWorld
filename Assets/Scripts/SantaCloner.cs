using UnityEngine;
using System.Collections;

public class SantaCloner : MonoBehaviour {

	public float speed = 0.5f;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Clone", speed, speed);
	}

	void Clone () {
		GameObject obj = NewObjectPooler.current.GetPooledObject ();
		if (obj != null) {
			obj.SetActive (true);
		}
	}
}
