using UnityEngine;
using System.Collections;
using Zenject;
public class LevelGenerator : MonoBehaviour {
	
	private ITextReader _textReader;
	// Use this for initialization
	[Inject]
	public void Construct(ITextReader textReader){
		_textReader = textReader;
	}

	void Start () {
		_textReader.Log();
	}

	void Print(){
		var level = _textReader.Read ("level.txt");
	}
	// Update is called once per frame

}
