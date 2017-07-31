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
		int[,] level = new int[8, 8] { 
			{1,1,1,1,1,1,0,1}, 
			{1,0,0,0,0,0,0,1}, 
			{1,0,0,1,1,1,1,1},
			{1,0,0,1,0,0,0,1},
			{1,1,0,0,0,1,0,1},
			{1,0,0,1,1,1,0,1}, 
			{1,0,0,0,0,0,0,1}, 
			{1,0,1,1,1,1,1,1}
		};
		for (int y = 0; y < level.GetLength(0); y++) {
			for (int x = 0; x < level.GetLength(1); x++) {
				if (level [y, x] > 0) {
					Debug.Log (y.ToString());
					GameObject brick = Instantiate (WallBrick);
					brick.layer = 8;
					brick.GetComponent<Transform> ().position = new Vector3 ((1.0f * x), (1.0f * -y), 0f);
				}
			}
		}
	}
}
