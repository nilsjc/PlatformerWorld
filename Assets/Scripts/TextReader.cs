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
		Debug.Log ("Testing DI");
	}

	public string Read(string name){
		if(Directory.Exists(name) || File.Exists(name)){
			StreamReader sr = new StreamReader (Path);
			var level = sr.ReadToEnd ();
			sr.Close ();
			return level;	
		}
			else{
				return "1110001210";
		}
	}
}
