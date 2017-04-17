using UnityEngine;
using System.Collections;

public class SantaKiller : MonoBehaviour {
	float speed = 1.5f;
	void OnEnable(){
		Invoke("Destroy", speed);
	}

	void Destroy(){
		this.gameObject.SetActive (false);
	}
}
