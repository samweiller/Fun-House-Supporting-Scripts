using UnityEngine;
using System.Collections;

public class portalControllerMaster : MonoBehaviour {

	public string[] roomOrder = new string[5] {"A3", "B3", "B4", "B5", "A5"};
	public string[] activePortals = new string[4];
//	private Material greenPortal = aPortalGreen;
//	private Material redPortal = aPortalRed;

	void Awake () {
		int levelNumber = 1;
//		roomOrder = new string[5] {"A3", "B3", "B4", "B5", "A5"};

//		switch(levelNumber)
//		{
//		case 1:
//			string[] theLevelRoomOrder = roomOrder;
//			break;
//		default:
//			string[] theLevelRoomOrder = roomOrder;
//			break;
//		}

	}

	void Start () {
		setPortals ();
		}

	// Use this for initialization
	void setPortals (int level) {
		int j = 0;
		for (int i = 0; i < roomOrder.Length-1; i++) {
			string doorNameA = roomOrder[i] + roomOrder[i+1];
			string doorNameB = roomOrder[i+1] + roomOrder[i];

			Debug.Log(doorNameA);
			Debug.Log(i);

			if(GameObject.Find (doorNameA) != null) {
//				renderer.material.color = Color.green;
				Debug.Log("Success for"+doorNameA+"!");
				activePortals[j] = doorNameA;
				j++;
			}
			if(GameObject.Find (doorNameB) != null) {
//				renderer.material.color = Color.green;
				Debug.Log("Success for"+doorNameB+"!");
				activePortals[j] = doorNameB;
				j++;
			}

//			if(myPortal == doorNameB) {
//				Debug.Log("Success for"+myPortal+"!");
//				activePortals[j] = myPortal;
//				j++;
//			}
//			else{
//				renderer.material.color = Color.red;
//			}
		}

		Debug.Log (activePortals);

		foreach (string portalToActivate in activePortals) {
			Debug.Log(portalToActivate);
			MeshRenderer theRenderer = GameObject.Find(portalToActivate).GetComponent<MeshRenderer>();
			theRenderer.material = Resources.Load<Material>("Materials/aPortalGreen");
			BoxCollider theCollider = GameObject.Find(portalToActivate).GetComponent<BoxCollider>();
			theCollider.enabled = false;

//			Component thePortal = GameObject.Find(portalToActivate).GetComponent<Renderer>;
//			thePortal.material.color = Color.green;
				}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
