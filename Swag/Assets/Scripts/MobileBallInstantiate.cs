using UnityEngine;
using System.Collections;

public class MobileBallInstantiate : MonoBehaviour {

    private GameObject ballPrefab;
    private int score;

    void Start () {
        //Grabs prefab from editor.
        ballPrefab = (GameObject)Resources.Load("Prefabs/ball");
    }
	
    //Instantiate ball into your box.
	public void InstantiateBall()
    {
        score++;
        Instantiate(ballPrefab, new Vector3(Random.Range(-9, 9), 1, Random.Range(-9, 9)), Quaternion.identity);
    }

    //Returns the score of the player.
    public int getScore()
    {
        return score;
    }
}
