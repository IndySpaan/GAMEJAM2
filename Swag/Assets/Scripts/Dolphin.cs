using UnityEngine;
using System.Collections;

public class Dolphin : MonoBehaviour {

    public Collider coll;
	public Animator anim;
	public float animcooldown;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.A))
        {
            StartCoroutine(startAnim());
        }
	
	}

	public void FishForBall(){
        
        //coll.isTrigger = true;
        //anim.SetBool ("Fish", true);
        
	}

    public IEnumerator startAnim()
    {
        coll.isTrigger = true;
        anim.SetBool("Fish", true);

        yield return new WaitForSeconds(0.5f);

        anim.SetBool("Fish", false);
        coll.isTrigger = false;

    }

	public void Idle(){

        //anim.SetBool("Fish", false);
        //coll.isTrigger = false;

	}


	IEnumerator Fade() {


		yield return new WaitForSeconds(animcooldown);
		
	}


}
