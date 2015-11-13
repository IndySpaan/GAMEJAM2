using UnityEngine;
using System.Collections;

public class NetworkManager : MonoBehaviour {

	public string playerPrefabName;

	// Use this for initialization
	void Start () {
		PhotonNetwork.ConnectUsingSettings("0.1");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void CreateRoom(){
		RoomOptions roomOptions = new RoomOptions() { isVisible = false, maxPlayers = 4 };
		PhotonNetwork.CreateRoom ("wow");
	}

	public void JoinRoom(){
		PhotonNetwork.JoinRoom ("wow");

	}


	void OnJoinedRoom()
	{
		// Spawn player
		PhotonNetwork.Instantiate(playerPrefabName, Vector3.zero, Quaternion.identity, 0);

	}

	void OnJoinedMaster(){


		Debug.Log ("RoomJoined");
	}
}
