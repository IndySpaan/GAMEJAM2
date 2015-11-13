using UnityEngine;
using System.Collections;

public class EatingScript : MonoBehaviour {

    public Dolphin dolphin;

    private float animcd;

    public void Start()
    {
        animcd = dolphin.animcooldown;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "collBall")
        {
            Debug.Log("Destroy ball");
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "collPUspeed")
        {
            StartCoroutine(PickUpSpeed());
            Destroy(other.gameObject);
        }

        
    }

    public IEnumerator PickUpSpeed()
    {
        Debug.Log("SUPERSPEED!");
        dolphin.animcooldown = 0.1f;
        yield return new WaitForSeconds(5f);
        dolphin.animcooldown = animcd;
        Debug.Log("superspeed ended");
    }
}
