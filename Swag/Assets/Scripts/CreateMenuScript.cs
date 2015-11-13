using UnityEngine;
using System.Collections;

public class CreateMenuScript : MonoBehaviour {

	public GameObject createRoomBtn;
	public GameObject joinRoom;

	// Use this for initialization
	void Start () {
		PhotonNetwork.ConnectUsingSettings("0.1");
		createRoomBtn.SetActive (false);
		joinRoom.SetActive (false);
	
	}
	
	// Update is called once per frame
	void Update () {

		if (PhotonNetwork.connectedAndReady) {

			createRoomBtn.SetActive (true);
			joinRoom.SetActive (true);

		}
	
	}


	public void JoinGame(){

		Application.LoadLevel ("boardScreen");

	}

    public void CreatGame()
    {
		PhotonNetwork.CreateRoom ("seemee");

		//TODO
		//Application.LoadLevel ("Game");
    }

	
	void OnJoinedRoom()
	{
		// Spawn player
		Application.LoadLevel("Game");
		
	}

    public void Quit()
    {
        Application.Quit();
    }
}
