using UnityEngine;
using System.Collections;

public class networkPlayer : MonoBehaviour {

	public bool test = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("space")) {

			test = !test;
		}
	
	}

	void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
		if (stream.isWriting)
		{
			stream.SendNext(test);
		}
		else
		{
			test = (bool)stream.ReceiveNext();
		}
	}
}
