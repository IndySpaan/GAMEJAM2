using UnityEngine;
using System.Collections;

public class ballInstantiate : MonoBehaviour {

    private GameObject ballPrefab;
    private GameObject InstantiatedBall;

    private int numberOfBalls = 100;

    private Vector3 explosionPosition;
    private float randomCorner;
    void Start ()
    {
        //Instantiating an amount of balls equal to numberOfBalls.
        //Adding a random force to the instantiated ball.
        ballPrefab = (GameObject)Resources.Load("Prefabs/ball");

        for(int i = 0; i < numberOfBalls; i++)
        {
            InstantiatedBall = (GameObject)Instantiate(ballPrefab, new Vector3(Random.Range(-10, 10), Random.Range(10, 15), Random.Range(-10, 10)), Quaternion.identity);
            InstantiatedBall.GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(-20, 20), -4, Random.Range(-20, 20));
        }
	}

    void Update()
    {
        if (Random.Range(0f, 1f) > 0.98f)
        {
            randomCorner = Random.Range(0f, 1f);

            if (randomCorner > 0.8f)
            {
                explosionPosition = new Vector3(-10.5f, 1, -10.5f);
            }
            else if (randomCorner > 0.6f)
            {
                explosionPosition = new Vector3(10.5f, 1, -10.5f);
            }
            else if (randomCorner > 0.4f)
            {
                explosionPosition = new Vector3(-10.5f, 1, 10.5f);
            }
            else if(randomCorner > 0.2f)
            {
                explosionPosition = new Vector3(10.5f, 1, 10.5f);
            }
            else
            {
                explosionPosition = new Vector3(0, 1, 0);
            }

            Collider[] colliders = Physics.OverlapSphere(explosionPosition, 10);
            foreach (Collider hit in colliders)
            {
                Rigidbody rb = hit.GetComponent<Rigidbody>();

                if (rb != null)
                    rb.AddExplosionForce(20, explosionPosition, 20, 3.0F);

            }
        }
    }
}
