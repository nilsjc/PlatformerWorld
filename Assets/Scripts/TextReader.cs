using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class TextReader : ITextReader {
	public string Path;
	// Use this for initialization
	void Start () {
		var level = Read(Path);
	}
	public void Log(){
		Debug.Log ("TextReader, Function Log Testing DI");
	}

	public string Read(string name){
		if(Directory.Exists(name) || File.Exists(name)){
			StreamReader sr = new StreamReader (name);
			var level = sr.ReadToEnd ();
			sr.Close ();
			return level;	
		}
			else
		{
			Debug.Log ("Text file is non existing");
			return null;
		}
	}
}
