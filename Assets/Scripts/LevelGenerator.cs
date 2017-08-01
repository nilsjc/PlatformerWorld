using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System;
using Zenject;
public class LevelGenerator : MonoBehaviour {
	public GameObject WallBrick;
	private ITextReader _textReader;
	// Use this for initialization
	[Inject]
	public void Construct(ITextReader textReader){
		_textReader = textReader;
	}

	void Start () {
		//_textReader.Log();
		Print (TextToArray());
	}

	public char[,] TextToArray(){
		char[,] levelArray = new char[32,24];
		var level = _textReader.Read ("C:\\level.txt");
		if (level == null) { 
			Debug.Log ("The so called text file is null!");
			return null;
		}
		Debug.Log (level);
		string[]lines = level.Split('\n');
		for (int Y = 0; Y < lines.Length; Y++) {
			var horizon = lines [Y].ToCharArray ();
			for (int X = 0; X < horizon.Length; X++) {
				levelArray [X, Y] = horizon [X];
			}
		}

		return levelArray;

	}

	public void Print(char[,]level){
		Debug.Log ("Array X length:" + level.GetLength (0).ToString ());
		Debug.Log ("Array Y length:" + level.GetLength (1).ToString ());
		for (int y = 0; y < level.GetLength(1); y++) {
			for (int x = 0; x < level.GetLength(0); x++) {
				if (level [x, y] == '1') {
					GameObject brick = Instantiate (WallBrick);
					brick.layer = 8;
					brick.GetComponent<Transform> ().position = new Vector3 ((1.0f * x), (1.0f * -y), 0f);
				}
			}
		}
	}

	public int[,]GetTestArray(){
		int[,] level = new int[11, 8] { 
			{'1','1','1','1','1','1','0','1'}, 
			{'1','0','0','0','0','0','0','1'}, 
			{'1','0','0','1','1','1','1','1'},
			{'1','0','0','1','0','0','0','1'},
			{'1','1','0','0','0','1','0','1'},
			{'1','0','0','1','1','1','0','1'}, 
			{'1','0','0','0','0','0','0','1'}, 
			{'1','0','1','1','1','1','1','1'},
			{'0','0','0','0','1','0','0','1'},
			{'1','1','1','0','0','0','1','1'},
			{'1','0','1','1','1','1','1','1'}
		};
		return level;
	}

}
