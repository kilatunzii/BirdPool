using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otherBalls : MonoBehaviour
{
    private Rigidbody birds;

    // Start is called before the first frame update
    void Start()
    {
        birds = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("CueBall"))
        {
            Vector3 collisionForce = collision.relativeVelocity * birds.mass;

            // Apply the collision force to the ball
            birds.AddForce(collisionForce, ForceMode.Impulse);

        }
    }

}
