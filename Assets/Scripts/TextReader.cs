using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class TextReader : MonoBehaviour {
	string Path;
	// Use this for initialization
	void Start () {

	}

	string Read(){
		StreamReader sr = new StreamReader (Path);
		var level = sr.ReadToEnd ();
		sr.Close ();
		return level;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
