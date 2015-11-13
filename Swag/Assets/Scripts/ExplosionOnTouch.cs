using UnityEngine;
using System.Collections;

public class ExplosionOnTouch : MonoBehaviour {
    public float PushPower = 1f;



    void OnCollisionEnter(Collision hit)
    {
        GameObject player = hit.gameObject;
        // If it is not a player, exit the method
        if (!player.tag.Equals("Player"))
            return;

        // Get the rigidbody
        Rigidbody body = player.GetComponent<Rigidbody>();
        if (body == null || body.isKinematic)
            return;

        // Give the force a direction
        Vector3 pushDir = new Vector3(hit.transform.position.x - this.transform.position.x, 0, hit.transform.position.y - this.transform.position.y) * 10 ;
        body.AddForce(pushDir * PushPower);
       
    }
}
