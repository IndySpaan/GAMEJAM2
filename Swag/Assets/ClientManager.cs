using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ClientManager : MonoBehaviour {

	public List<Room> availiblerooms;
	public List<GameObject> physicalButtons;

	public string playerPrefabName;

	public GameObject parent;

	public GameObject roombutton;
	public float timeInterval;

	float timer;

	// Use this for initialization
	void Start () {
	
		physicalButtons = new List<GameObject> ();
		availiblerooms = new List<Room> ();

		PhotonNetwork.JoinRoom ("seemee");

	}


	void OnJoinedRoom()
	{
		// Spawn player
		PhotonNetwork.Instantiate(playerPrefabName, Vector3.zero, Quaternion.identity, 0);
		
	}
	
	// Update is called once per frame
//	void Update () {
//	
//		timer = timer + 1 * Time.deltaTime;
//		if (timer >= timeInterval) {
//
//			Debug.Log("Refresing...");
//
//			if(physicalButtons != null){
//			foreach (GameObject tempbutton in physicalButtons) {
//				
//					Destroy(tempbutton);
//				
//			}
//				physicalButtons.Clear();
//			}
//
//			Debug.Log("Roomlist : " + PhotonNetwork.GetRoomList().ToString());
//
//			foreach (RoomInfo r in PhotonNetwork.GetRoomList()) {
//
//				GameObject temp = Instantiate(roombutton, Vector3.zero, Quaternion.identity) as GameObject;
//				temp.GetComponent<Room_UI>().roomName = r.name;
//				temp.transform.SetParent(parent.transform);
//				physicalButtons.Add(temp);
//
//			}
//
//			timer = 0;
//		}
//	
//	}
}
