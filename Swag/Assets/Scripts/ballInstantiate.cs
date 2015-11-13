using UnityEngine;
using System.Collections;

public class ballInstantiate : MonoBehaviour
{

    private GameObject ballPrefab;
    private GameObject InstantiatedBall;

    private int numberOfBalls = 100;

    private Vector3 explosionPosition;
    private float randomCorner;
    void Start()
    {
        //Instantiating an amount of balls equal to numberOfBalls.
        //Adding a random force to the instantiated ball.
        ballPrefab = (GameObject)Resources.Load("Prefabs/ball");
        GameObject parent = new GameObject();
        parent.name = "Ballen";

        for (int i = 0; i < numberOfBalls; i++)
        {
            InstantiatedBall = (GameObject)Instantiate(ballPrefab, new Vector3(0, this.transform.position.y - 1, 0), Quaternion.identity);
            InstantiatedBall.GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(-20, 20), -4, Random.Range(-20, 20));
            InstantiatedBall.transform.SetParent(parent.transform);
        }
    }

    void FixedUpdate()
    {
        explosions();

    }

    void explosions()
    {
        {
            if (Random.Range(0f, 2f) > 1.99f)
            {
               
                    explosionPosition = new Vector3(0, 1, 0);
                

                Collider[] colliders = Physics.OverlapSphere(explosionPosition, 10);
                foreach (Collider hit in colliders)
                {
                    Rigidbody rb = hit.GetComponent<Rigidbody>();

                    if (rb != null)
                        rb.AddExplosionForce(-20, explosionPosition, 20, 3.0F);

                }
            }
        }
    }
}

