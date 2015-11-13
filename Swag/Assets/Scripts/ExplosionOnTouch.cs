using UnityEngine;
using System.Collections;

public class ExplosionOnTouch : MonoBehaviour {
    public float PushPower = 10f;



    void OnCollisionEnter(Collision hit)
        
    {
        GameObject player = hit.gameObject;
        // If it is not a player, exit the method
        if (!player.tag.Equals("Player") || !player.tag.Equals("Ball"))
            return;
        Debug.Log("Get body");
        // Get the rigidbody
        Rigidbody body = player.GetComponent<Rigidbody>();
        //if (body == null)
        //    return;

        // Give the force a direction
        Debug.Log("Push the ball");
        Vector3 pushDir = (hit.transform.position - this.transform.position) * 10 + new Vector3(0, 5, 0);
        body.AddForce(pushDir * PushPower);

    }
}
