using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Room_UI : MonoBehaviour {

	public Text t;
	public string roomName;

	// Use this for initialization
	void Start () {
	
		t.text = roomName;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void JoinRoom(){

		PhotonNetwork.JoinRoom (roomName);

	}
}
