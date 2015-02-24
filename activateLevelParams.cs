using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class activateLevelParams : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	
	// Update is called once per frame
	void OnTriggerEnter (Collider other) {
		Debug.Log ("Trigger is hit!");

		GameObject.Find("theSubject").rigidbody.velocity = Vector3.zero;
		GameObject.Find("theSubject").transform.position = mazeParams.roomCoordinates["A3"]; // Make dynamic

		
	}

	public string[] roomOrder = new string[5] {"A3", "B3", "B4", "B5", "A5"};
	public string[] activePortals = new string[4];


	void setPortals (int level) {
		// use switch statement on level to choose roomOrder string array

		int j = 0;
		for (int i = 0; i < roomOrder.Length-1; i++) {
			string doorNameA = roomOrder[i] + roomOrder[i+1];
			string doorNameB = roomOrder[i+1] + roomOrder[i];
			
			Debug.Log(doorNameA);
			Debug.Log(i);
			
			if(GameObject.Find (doorNameA) != null) {
//				Debug.Log("Success for"+doorNameA+"!");
				activePortals[j] = doorNameA;
				j++;
			}
			if(GameObject.Find (doorNameB) != null) {
//				Debug.Log("Success for"+doorNameB+"!");
				activePortals[j] = doorNameB;
				j++;
			}
		}
		
//		Debug.Log (activePortals);
		
		foreach (string portalToActivate in activePortals) {
			Debug.Log(portalToActivate);
			MeshRenderer theRenderer = GameObject.Find(portalToActivate).GetComponent<MeshRenderer>();
			theRenderer.material = Resources.Load<Material>("Materials/aPortalGreen");
			BoxCollider theCollider = GameObject.Find(portalToActivate).GetComponent<BoxCollider>();
			theCollider.enabled = false;
		}
	}
}