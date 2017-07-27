using UnityEngine;
using System.Collections;
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
		_textReader.Log();
		Print ();
	}

	void Print(){
		//var level = _textReader.Read ("level.txt");
		var level = "11111111\\r\\n10000001\\r\\n10000001\\r\\n11111111";
		for (int i = 0; i < 8; i++) {
			GameObject brick = Instantiate (WallBrick);
			brick.GetComponent<Transform> ().position = new Vector3 ((1.0f * i), 1.0f, 0f);	
		}

	}
}
