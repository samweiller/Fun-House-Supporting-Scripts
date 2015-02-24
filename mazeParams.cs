using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class mazeParams : MonoBehaviour {

	public static Dictionary<string, Vector3> roomCoordinates = new Dictionary<string, Vector3>();
	public static Dictionary<string, string[]> levelPaths = new Dictionary<string, string[]>();

	private string[] lev1 = new string[5] {"A3", "B3", "B4", "B5", "A5"};
	private string[] lev2 = new string[4] {"B3", "C3", "D3", "D4"};
	private string[] lev3 = new string[5] {"E4", "D4", "D3", "D2", "C2"};
	private string[] lev4 = new string[6] {"D2", "E2", "E3", "D3", "C3", "C4"};
	private string[] lev5 = new string[4] {"C3", "D3", "E3", "F3"};

	// Use this for initialization
	void Awake () {

		levelPaths.Add("Level1",);

		foreach (Transform item in this.transform) {
			var theNewPosition = new Vector3(item.position.x, item.position.y+30, item.position.z-50);
			roomCoordinates.Add(item.name, theNewPosition);
//			Debug.Log (roomCoordinates[item.name]);
//			Debug.Log(item.position);
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
